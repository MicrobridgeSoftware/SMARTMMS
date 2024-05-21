using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Mbridge.Common.Application.Authorization.Users.Dto;
using Mbridge.Common.Presentation.Utilities;
using MBridge.SMARTMMS.Application.Posts;
using System.Collections.ObjectModel;
using Mbridge.SMARTMMS.Persistence;
using System.IO;
using System.Linq;
using System.Data.Entity;
using Telerik.WinControls.UI;
using System.Transactions;
using SMARTMMS.Util;
using System.Data.Entity.Infrastructure;
using SMARTMMS.Forms.Popup_Dialogs;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI.Export;

namespace SMARTMMS.Forms.Maintenance
{
    public partial class MemberForm : Telerik.WinControls.UI.RadForm
    {
        List<Member> memberList;
        List<TitleOfCourtesy> titleList;
        List<MaritalStatus> maritalList;
        List<Parish> parishList;
        List<Zone> zoneList;
        List<RelationType> relationTypeList;
        List<Institution> institutionList;
        List<EducationLevel> educationLevelList;
        List<Skill> skillList;
        List<SkillLevel> skillLevelList;
        List<Post> postList;
        List<AnniversaryType> anniversaryTypeList;
        List<GenderDefinition> genderDefinition;
        List<MemberDefinition> memberDefinition;
        List<Congregation> congregationList;
        List<MemberAttachment> memberAttachments;
        List<EmploymentStatusDefinition> employmentStatuses;
        List<DiaryNotes> diaryNotes;
        List<DisFellowshipReasons> memberStatus;
        List<CareGroup> careGroupList;
        MMSDbContext dbContext = new MMSDbContext();

        private readonly IMemberApplicationService _memberAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;
        ErrorProvider errorProvider = new ErrorProvider();

        public MemberForm(UserInfo userInfo, IUIManager uIManager, IMemberApplicationService memberAppService) : this()
        {
            _uIManager = uIManager;
            _memberAppService = memberAppService;
            _userInfo = userInfo;
        }

        public MemberForm()
        {
            InitializeComponent();
        }

        private void InitializezformControls()
        {
            grdNOKDataDisplay.Rows.Clear();
            grdAnniversaryDisplay.Rows.Clear();
            grdEducationDisplay.Rows.Clear();
            grdPostDisplay.Rows.Clear();
            grdRelationDisplay.Rows.Clear();
            grdSkillsDisplay.Rows.Clear();
            grdAttachmentDisplay.Rows.Clear();

            dtpAnniversary.Value = DateTime.Today.Date;
            dtpEffectiveDate.Value = DateTime.Today.Date;
            dtpEndDate.NullText = "Null";
            dtpEndDate.SetToNullValue();

            foreach(Control control in radGroupBox1.Controls)            
                if (control is RadTextBox)
                    ((RadTextBox)control).Text = string.Empty;

            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is RadTextBox)
                    ((RadTextBox)c).Text = string.Empty;

                if (c is RadDropDownList)
                    ((RadDropDownList)c).SelectedIndex = -1;
            }
        }

        private void ManipulateFormControls(string mode, bool shouldEnable)
        {
            btnAddImg.Enabled = shouldEnable;
            grdData.Enabled = shouldEnable == true ? false : true;
            //chkActive.Enabled = shouldEnable;

            foreach (Control c in tableLayoutPanel1.Controls)
                c.Enabled = shouldEnable;

            txtMemberNo.Enabled = false;

            grdEducationDisplay.Enabled = shouldEnable;
            grdNOKDataDisplay.Enabled = shouldEnable;
            grdPostDisplay.Enabled = shouldEnable;
            grdRelationDisplay.Enabled = shouldEnable;
            grdSkillsDisplay.Enabled = shouldEnable;
            grdAnniversaryDisplay.Enabled = shouldEnable;
            grdAttachmentDisplay.Enabled = shouldEnable;
            ddlAnniversary.Enabled = shouldEnable;
            ddlEducationLevel.Enabled = shouldEnable;
            ddlInstitution.Enabled = shouldEnable;
            ddlMember.Enabled = shouldEnable;
            ddlPostName.Enabled = shouldEnable;
            ddlRelationType.Enabled = shouldEnable;
            ddlSkillLevel.Enabled = shouldEnable;
            ddlSkillName.Enabled = shouldEnable;
            btnAnniversaryAdd.Enabled = shouldEnable;
            btnEducationAdd.Enabled = shouldEnable;
            btnPostAdd.Enabled = shouldEnable;
            btnRelationAdd.Enabled = shouldEnable;
            btnSkillsAdd.Enabled = shouldEnable;
            txtQualification.Enabled = shouldEnable;
            dtpEffectiveDate.Enabled = shouldEnable;
            dtpEndDate.Enabled = shouldEnable;
            dtpAnniversary.Enabled = shouldEnable;
            txtFirstName.Enabled = shouldEnable;
            txtLastName.Enabled = shouldEnable;
            txtMiddleName.Enabled = shouldEnable;
            txtAlias.Enabled = shouldEnable;
            radBrowseEditor.Enabled = shouldEnable;
            txtImageName.Enabled = shouldEnable;

            if (mode == "Edit")
            {
                txtMemberNo.Enabled = false;
                btnEndMembership.Enabled = shouldEnable;
                //btnRejoin.Enabled = shouldEnable;
                btnRemoveImg.Enabled = shouldEnable;//true;
            }

            if (!shouldEnable)
                btnRemoveImg.Enabled = false;
        }
                
        private void btnAddImg_Click(object sender, EventArgs e)
        {            
            if (pictureBox.Image != null)
            {
                RadMessageBox.Show("You should remove the current image before trying to add a new one!", Application.ProductName);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (openFileDialog.ShowDialog(this.Parent) == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    byte[] data;
                    Bitmap bmp;

                    string fileName = openFileDialog.FileName;

                    using (FileStream fs = File.OpenRead(fileName))
                    {
                        data = new byte[fs.Length];
                        fs.Read(data, 0, data.Length);

                        MemoryStream ms = new MemoryStream(data);
                        bmp = new Bitmap(ms);

                        pictureBox.Image = bmp;
                    }
                }
            }
        }

        private void btnRemoveImg_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                DialogResult _promptUser = RadMessageBox.Show("Are you sure you want to remove this member image?", Application.ProductName, MessageBoxButtons.YesNo);

                if (_promptUser == DialogResult.Yes)
                {
                    pictureBox.Image = null;
                    int picId = Convert.ToInt32(((Member)bindingSourceMember.Current).PhotoId);
                    int memberId = ((Member)bindingSourceMember.Current).MemberId;

                    var getImageRecord = dbContext.BinaryObjects.Where(x => x.BinaryObjectId == picId).FirstOrDefault();

                    if (getImageRecord != null)
                    {
                        try
                        {
                            var getMember = dbContext.Members.Where(x => x.MemberId == memberId).FirstOrDefault();

                            if (getMember != null)
                                getMember.PhotoId = null;

                            dbContext.BinaryObjects.Remove(getImageRecord);

                            dbContext.SaveChanges();

                            ((Member)bindingSourceMember.Current).BinaryObject = null;

                            RadMessageBox.Show("Member image removed successfully!", Application.ProductName);

                            ManipulateFormControls("", false);
                        }
                        catch (Exception _exp)
                        {
                            RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                        }
                    }
                }
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            dtpAnniversary.MaxDate = DateTime.Today.Date;
            dtpEffectiveDate.MaxDate = DateTime.Today.Date;
            dtpAnniversary.Value = DateTime.Today.Date;
            dtpEffectiveDate.Value = DateTime.Today.Date;
            dtpMemberEffective.MaxDate = DateTime.Today.Date;
            dtpMemberEffective.Value = DateTime.Today.Date;
            dtpDateOfBirth.MaxDate = DateTime.Today.Date;

            memberList = new List<Member>();
            titleList = new List<TitleOfCourtesy>();
            maritalList = new List<MaritalStatus>();
            parishList = new List<Parish>();
            zoneList = new List<Zone>();
            relationTypeList = new List<RelationType>();
            institutionList = new List<Institution>();
            educationLevelList = new List<EducationLevel>();
            skillList = new List<Skill>();
            skillLevelList = new List<SkillLevel>();
            postList = new List<Post>();
            anniversaryTypeList = new List<AnniversaryType>();
            genderDefinition = new List<GenderDefinition>();
            congregationList = new List<Congregation>();
            employmentStatuses = new List<EmploymentStatusDefinition>();
            diaryNotes = new List<DiaryNotes>();
            memberStatus = new List<DisFellowshipReasons>();
            careGroupList = new List<CareGroup>();

            genderDefinition.Add(new GenderDefinition { genderId = 1, genderInitial = "M" });
            genderDefinition.Add(new GenderDefinition { genderId = 2, genderInitial = "F" });

            employmentStatuses.Add(new EmploymentStatusDefinition { statusId = 1, status = "N/A" });
            employmentStatuses.Add(new EmploymentStatusDefinition { statusId = 1, status = "Employed" });
            employmentStatuses.Add(new EmploymentStatusDefinition { statusId = 1, status = "Unemployed" });

            titleList = dbContext.TitleOfCourtesies.Where(x => x.IsActive).AsNoTracking().ToList();
            maritalList = dbContext.MaritalStatuses.Where(x => x.IsActive).AsNoTracking().ToList();
            parishList = dbContext.Parishes.AsNoTracking().ToList();
            zoneList = dbContext.Zones.Where(x => x.IsActive).AsNoTracking().ToList();
            relationTypeList = dbContext.RelationTypes.Where(x => x.IsActive).AsNoTracking().ToList();
            institutionList = dbContext.Institutions.AsNoTracking().ToList();
            educationLevelList = dbContext.EducationLevels.Where(x => x.IsActive).AsNoTracking().ToList();
            skillList = dbContext.Skills.Where(x => x.IsActive).AsNoTracking().ToList();
            skillLevelList = dbContext.SkillLevels.AsNoTracking().ToList();
            postList = dbContext.Posts.Where(x => x.IsActive).AsNoTracking().ToList();
            anniversaryTypeList = dbContext.AnniversaryTypes.Where(x => x.IsActive).AsNoTracking().ToList();
            congregationList = dbContext.Congregations.AsNoTracking().ToList();
            memberStatus = dbContext.DisFellowshipReasons.AsNoTracking().ToList();
            careGroupList = dbContext.CareGroups.AsNoTracking().ToList();

            bindingSourceMarital.DataSource = maritalList;
            bindingSourceParish.DataSource = parishList;
            bindingSourceTitle.DataSource = titleList;
            bindingSourceZone.DataSource = congregationList;// zoneList;
            bindingSourceNOKRelType.DataSource = relationTypeList;
            bindingSourceRelation.DataSource = relationTypeList;
            bindingSourceGridRelationshipType.DataSource = relationTypeList;
            bindingSourceInstitution.DataSource = institutionList;
            bindingSourceEducationLevel.DataSource = educationLevelList;
            bindingSourceSkill.DataSource = skillList;
            bindingSourceSkillLevel.DataSource = skillLevelList;
            bindingSourcePost.DataSource = postList;
            bindingSourceAnniversaryType.DataSource = anniversaryTypeList;
            bindingSourcegender.DataSource = genderDefinition;
            bindingSourceGridEducationLevel.DataSource = educationLevelList;
            bindingSourceGridSkill.DataSource = skillList;
            bindingSourceGridPost.DataSource = postList;
            bindingSourceGridAnniversary.DataSource = anniversaryTypeList;
            bindingSourceGridSkillLevel.DataSource = skillLevelList;
            bindingSourceMemberStatus.DataSource = memberStatus;
            bindingSourceEmpStatus.DataSource = employmentStatuses;
            bindingSourceZone2.DataSource = zoneList;
            bindingSourceCareGroup.DataSource = careGroupList;

            this.ddlAnniversary.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlEducationLevel.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlGender.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlInstitution.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlMaritalStatus.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlMember.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlParish.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlPostName.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlRelationType.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlSkillLevel.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlSkillName.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlTitle.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlZone.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlMemberStatus.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlEmpStatus.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlZone2.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlCareGroup.DropDownListElement.AutoCompleteAppend.LimitToList = true;

            this.radBrowseEditor.DialogType = BrowseEditorDialogType.OpenFileDialog;
            OpenFileDialog dialog = (OpenFileDialog)radBrowseEditor.BrowseDialog;
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            grdAttachmentDisplay.TableElement.RowHeight = 70;

            bgwMember.RunWorkerAsync();
            _uIManager.SetBusy(radGroupBox2);
        }

        private void bindingSourceMember_PositionChanged(object sender, EventArgs e)
        {
            if (((Member)bindingSourceMember.Current).MemberId > 0)
            {
                if (((Member)bindingSourceMember.Current).BinaryObject != null)
                {
                    Bitmap bmp;
                    byte[] data;
                    var bytes = (byte[])((Member)bindingSourceMember.Current).BinaryObject.Bytes.ToArray();
                    data = new byte[bytes.Length];
                    MemoryStream ms = new MemoryStream(bytes);
                    bmp = new Bitmap(ms);
                    pictureBox.Image = bmp;
                }
                else
                    pictureBox.Image = null;

                int memberId = ((Member)bindingSourceMember.Current).MemberId;
                List<MemberNextOfKin> nextOfKin = ((Member)bindingSourceMember.Current).MemberNextOfKins.ToList();
                //List<int> relatedMemberIds = new List<int>();
                //relatedMemberIds = ((Member)bindingSourceMember.Current).MemberRelation.Select(x => x.RelatedMemberId).Distinct().ToList();
                List<MemberRelation> relations = /*memberList.Where(x => relatedMemberIds.Contains(x.MemberId)).ToList();*/((Member)bindingSourceMember.Current).MemberRelation.ToList();
                List<MemberEducation> educations = ((Member)bindingSourceMember.Current).MemberEducation.ToList();
                List<MemberSkill> skills = ((Member)bindingSourceMember.Current).MemberSkill.ToList();
                List<MemberPost> posts = ((Member)bindingSourceMember.Current).MemberPosts.ToList();
                List<MemberAnniversary> anniversaries = ((Member)bindingSourceMember.Current).MemberAnniversaries.ToList();
                List<MemberAttachment> attachments = memberAttachments.Where(x => x.MemberId == memberId).ToList();
                
                var memberRelations = (from r in relations
                                       join m in memberList on r.RelatedMemberId equals m.MemberId
                                       select new
                                        {
                                            m,
                                            r
                                        }).ToList();

                List<MemberRelationDefinition> memberRelationship = new List<MemberRelationDefinition>();

                foreach (var relation in memberRelations)
                    memberRelationship.Add(new MemberRelationDefinition
                    {
                        FirstName = relation.m.FirstName,
                        LastName = relation.m.LastName,
                        MemberId = relation.m.MemberId,
                        MemberNo = relation.m.MemberNo,
                        MemberRelationId = relation.r.MemberRelationId,
                        RelationTypeId = relation.r.RelationTypeId
                    });

                var memberNotes = diaryNotes.Where(x => x.MemberId == memberId).ToList();

                grdNOKDataDisplay.DataSource = nextOfKin;
                grdRelationDisplay.DataSource = memberRelationship;// memberRelations;// query;// relations;
                grdEducationDisplay.DataSource = educations;
                grdSkillsDisplay.DataSource = skills;
                grdPostDisplay.DataSource = posts;
                grdAnniversaryDisplay.DataSource = anniversaries;
                grdAttachmentDisplay.DataSource = attachments;
                grdCommentary.DataSource = memberNotes;

                MemoryManagement.FlushMemory();
            }
            else
                pictureBox.Image = null;            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var _enabledTextBoxes = this.tableLayoutPanel1.Controls.OfType<RadTextBox>().Where(x => x.Enabled == true).ToList();

            if (_enabledTextBoxes.Count > 0)
            {
                bindingSourceMember.RemoveCurrent();
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new member record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == DialogResult.No)
                return;

            ManipulateFormControls("Add", true);
            InitializezformControls();
            grdCommentary.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _enabledTextBoxes = this.tableLayoutPanel1.Controls.OfType<RadTextBox>().Where(x => x.Enabled == true).ToList();

            if (_enabledTextBoxes.Count <= 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to save this member record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == DialogResult.No)
                return;

            int errorCount = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control.Tag != null && control.Tag.ToString().Trim() != string.Empty)
                {
                    errorProvider.SetError(control, "");

                    if (control is RadTextBox && control.Text.Trim().Equals(string.Empty))
                        errorProvider.SetError(control, "This is a required field!");
                    else if (control is RadDropDownList && (((RadDropDownList) control).SelectedValue == null || ((RadDropDownList)control).SelectedIndex < 0 || ((RadDropDownList)control).Text.Trim() == ""))
                        errorProvider.SetError(control, "This is a required field!");
                    else if (control is RadMaskedEditBox && (((RadMaskedEditBox)control).Text.Equals("1/1/0001") || ((RadMaskedEditBox)control).Text.Equals("01/Jan/0001")))
                        errorProvider.SetError(control, "This is a required field!");

                    if (errorProvider.GetError(control) != "")
                        errorCount++;
                }
            }

            foreach (Control control in radGroupBox1.Controls)
            {
                if (control.Tag != null)
                {
                    errorProvider.SetError(control, "");

                    if (control is RadTextBox && control.Text.Trim().Equals(string.Empty))
                        errorProvider.SetError(control, "This is a required field!");

                    if (errorProvider.GetError(control) != "")
                        errorCount++;
                }
            }
            
            //if (((Member)bindingSourceMember.Current).MemberId == 0)
            //{
            //    using (MMSDbContext dbContext = new MMSDbContext())
            //    {
            //        bool memberNoExist = dbContext.Members.Where(x => x.MemberNo.Trim().ToUpper().Equals(txtMemberNo.Text.Trim().ToUpper())).AsNoTracking().Any();

            //        if (memberNoExist)
            //        {
            //            errorProvider.SetError(txtMemberNo, "This number is already assigned!");
            //            errorCount++;
            //        }
            //    }
            //}

            bool invaliNOKRowsExist = grdNOKDataDisplay.Rows.Where(x => x.Cells["FirstName0"].Value != null && x.Cells["NOKRelType"].Value == null).Any();

            if (invaliNOKRowsExist)
            {
                RadMessageBox.Show("A relationship type is required for this next of kin!", Application.ProductName);
                errorCount++;
            }

            if (radBrowseEditor.Value != null)
            {
                if (txtImageName.Text.Trim().Equals(string.Empty))
                {
                    RadMessageBox.Show("An associated name is required for this attachment!", Application.ProductName);
                    errorCount++;
                }

                var bytes = new FileInfo(radBrowseEditor.Value.ToString()).Length;

                if ((int)bytes > 262144)
                {
                    RadMessageBox.Show("Attachment sizes must be less than or equal to 256K!", Application.ProductName);
                    errorCount++;
                }                
            }

            if (dtpMemberEffective.Value == null)
            {
                errorProvider.SetError(dtpMemberEffective, "This is a required field!");
                errorCount++;
            }

            if (dtpDateOfBirth.Value == null)
            {
                errorProvider.SetError(dtpDateOfBirth, "This is a required field!");
                errorCount++;
            }

            if (!txtEmailAddress.Text.Trim().Equals(string.Empty))
            {
                bool validEmail = ValidateEmailAddress.IsValidEmail(txtEmailAddress.Text.Trim());

                if (!validEmail)
                {
                    RadMessageBox.Show("Please supply a valid email address!", Application.ProductName);
                    errorCount++;
                }
            }

            if (errorCount > 0)
                return;

            try
            {
                List<object> bgwargument = new List<object>();
                bgwargument.Add("Save Data");
                bgwMember.RunWorkerAsync(bgwargument);
                _uIManager.SetBusy(radGroupBox2);
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void grdNOKDataDisplay_RowValidating(object sender, RowValidatingEventArgs e)
        {
            if (e.Row.Cells["FirstName0"].Value != null)
            {
                if (e.Row.Cells["FirstName0"].Value.ToString().Trim().Equals(string.Empty))
                {
                    RadMessageBox.Show("The first name of this next of kin should be supplied!", Application.ProductName);
                    e.Cancel = true;
                }

                if (e.Row.Cells["LastName0"].Value == null || e.Row.Cells["LastName0"].Value.ToString().Trim().Equals(string.Empty))
                {
                    RadMessageBox.Show("The last name of this next of kin should be supplied!", Application.ProductName);
                    e.Cancel = true;
                }                

                if (e.Row.Cells["NOKRelType"].Value == null)
                {
                    RadMessageBox.Show("A relationship type is required for this next of kin!", Application.ProductName);
                    e.Cancel = true;
                }
            }
        }

        private void bgwMember_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> _argumentList = e.Argument as List<object>;

            if (_argumentList != null && _argumentList.Count > 0)
            {
                using (var transcope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead }))
                {
                    using (MMSDbContext dbContext = new MMSDbContext())
                    {
                        int userId = _userInfo.UserId;
                        DateTime transactionDate = DateTime.Now;

                        if (((Member)bindingSourceMember.Current).MemberId == 0)
                        {
                            int photoObjectId = 0;

                            if (pictureBox.Image != null)
                            {
                                byte[] data;
                                
                                Bitmap bitmap = (Bitmap)pictureBox.Image.Clone();
                                ImageConverter converter = new ImageConverter();
                                data = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

                                BinaryObject binaryObject = new BinaryObject();
                                binaryObject.Bytes = data;
                                dbContext.BinaryObjects.Add(binaryObject);
                                dbContext.SaveChanges();

                                photoObjectId = binaryObject.BinaryObjectId;
                            }

                            Member addMember = new Member();
                            addMember.Address1 = txtAddress1.Text.Trim();
                            addMember.Address2 = txtAddress2.Text.Trim();
                            addMember.Alias = txtAlias.Text;
                            addMember.CellPhone = maskCellPhone.Text.ToString();
                            addMember.CreationTime = transactionDate;
                            addMember.CreatorUserId = userId;
                            addMember.DateOfBirth = dtpDateOfBirth.Value;
                            addMember.FirstName = txtFirstName.Text.Trim();
                            addMember.Gender = ddlGender.SelectedValue.ToString();
                            addMember.HomePhone = maskHomePhone.Text.ToString();
                            addMember.IsActive = true;
                            addMember.LastName = txtLastName.Text.Trim();
                            addMember.MaritalStatusId = Convert.ToInt16(ddlMaritalStatus.SelectedValue);
                            addMember.MemberNo = "";// txtMemberNo.Text.Trim();
                            addMember.MiddleName = txtMiddleName.Text.Trim();
                            addMember.ParishId = Convert.ToInt16(ddlParish.SelectedValue);

                            if (photoObjectId > 0)
                                addMember.PhotoId = photoObjectId;

                            addMember.TitleOfCourtesyId = Convert.ToInt16(ddlTitle.SelectedValue);
                            addMember.Town = txtTown.Text.Trim();
                            addMember.WorkPhone = maskWorkPhone.Text.ToString();
                            addMember.CongregationId = Convert.ToInt16(ddlZone.SelectedValue);
                            addMember.EmailAddress = txtEmailAddress.Text.Trim();
                            addMember.EmploymentStatus = ddlEmpStatus.SelectedValue.ToString();
                            addMember.Occupation = txtOccupation.Text.Trim();
                            addMember.MemberStatusId = Convert.ToInt32(ddlMemberStatus.SelectedValue);

                            int congId = Convert.ToInt16(ddlZone.SelectedValue);
                            short zoneId = Convert.ToInt16(ddlZone2.SelectedValue); ;// congregationList.Where(x => x.CongregationId == congId).Select(x => x.ZoneId).FirstOrDefault();

                            addMember.ZoneId = zoneId;
                            addMember.LastMembershipEffectiveDate = dtpMemberEffective.Value;
                            addMember.CareGroupId = Convert.ToInt16(ddlCareGroup.SelectedValue);
                            dbContext.Members.Add(addMember);

                            MemberMovement memberMovement = new MemberMovement();
                            memberMovement.CreationTime = transactionDate;
                            memberMovement.CreatorUserId = userId;
                            memberMovement.IsActive = true;
                            memberMovement.MembershipEffectiveDate = dtpMemberEffective.Value;
                            addMember.MemberMovement.Add(memberMovement);
                            dbContext.SaveChanges();

                            int memberId = addMember.MemberId;
                            UpdateRelatedDataTables(transactionDate, userId, memberId);
                        }
                        else
                        {
                            int memberId = ((Member)bindingSourceMember.Current).MemberId;

                            var getMemberRecord = dbContext.Members.Where(x => x.MemberId == memberId).FirstOrDefault();
                            getMemberRecord.Address1 = txtAddress1.Text.Trim();
                            getMemberRecord.Address2 = txtAddress2.Text.Trim();
                            getMemberRecord.Alias = txtAlias.Text;
                            getMemberRecord.CellPhone = maskCellPhone.Text.ToString();
                            getMemberRecord.LastModifiedTime = transactionDate;
                            getMemberRecord.LastModifierUserId = userId;
                            getMemberRecord.DateOfBirth = dtpDateOfBirth.Value;
                            getMemberRecord.FirstName = txtFirstName.Text.Trim();
                            getMemberRecord.Gender = ddlGender.SelectedValue.ToString();
                            getMemberRecord.HomePhone = maskHomePhone.Text.ToString();
                            //getMemberRecord.IsActive = chkActive.Checked == true ? true : false;
                            getMemberRecord.LastName = txtLastName.Text.Trim();
                            getMemberRecord.MaritalStatusId = Convert.ToInt16(ddlMaritalStatus.SelectedValue);
                            getMemberRecord.MiddleName = txtMiddleName.Text.Trim();
                            getMemberRecord.ParishId = Convert.ToInt16(ddlParish.SelectedValue);
                            getMemberRecord.TitleOfCourtesyId = Convert.ToInt16(ddlTitle.SelectedValue);
                            getMemberRecord.Town = txtTown.Text.Trim();
                            getMemberRecord.WorkPhone = maskWorkPhone.Text.ToString();
                            getMemberRecord.CongregationId = Convert.ToInt16(ddlZone.SelectedValue);
                            getMemberRecord.EmailAddress = txtEmailAddress.Text.Trim();
                            getMemberRecord.EmploymentStatus = ddlEmpStatus.SelectedValue.ToString();
                            getMemberRecord.Occupation = txtOccupation.Text.Trim();
                            getMemberRecord.MemberStatusId = Convert.ToInt32(ddlMemberStatus.SelectedValue);

                            int congId = Convert.ToInt16(ddlZone.SelectedValue);
                            short zoneId = Convert.ToInt16(ddlZone2.SelectedValue);//congregationList.Where(x => x.CongregationId == congId).Select(x => x.ZoneId).FirstOrDefault();

                            getMemberRecord.ZoneId = zoneId;
                            getMemberRecord.CareGroupId = Convert.ToInt16(ddlCareGroup.SelectedValue);

                            if (((Member)bindingSourceMember.Current).BinaryObject == null && pictureBox.Image != null)
                            {
                                byte[] data;

                                Bitmap bitmap = (Bitmap)pictureBox.Image.Clone();
                                ImageConverter converter = new ImageConverter();
                                data = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

                                BinaryObject binaryObject = new BinaryObject();
                                binaryObject.Bytes = data;
                                dbContext.BinaryObjects.Add(binaryObject);
                                dbContext.SaveChanges();

                                getMemberRecord.PhotoId = binaryObject.BinaryObjectId;
                            }

                            getMemberRecord.LastMembershipEffectiveDate = dtpMemberEffective.Value;

                            var getTransactionRecord = dbContext.MemberMovements.Where(x => x.MemberId == memberId && /*!x.IsActive*/ x.MembershipEndDate == null).FirstOrDefault();

                            if (getTransactionRecord != null)
                            {
                                if (getMemberRecord.LastMembershipEffectiveDate != dtpMemberEffective.Value.Date)
                                {
                                    //getMemberRecord.LastMembershipEffectiveDate = dtpMemberEffective.Value;//added above on Marowas request
                                    getTransactionRecord.MembershipEffectiveDate = dtpMemberEffective.Value;
                                }

                                if (((Member)bindingSourceMember.Current).MemberStatusId != Convert.ToInt32(ddlMemberStatus.SelectedValue))
                                {
                                    int memberStatusId = Convert.ToInt32(ddlMemberStatus.SelectedValue);
                                    var status = memberStatus.Where(x => x.DisFellowshipReasonsId == memberStatusId).FirstOrDefault();

                                    if (status.IsActive)
                                    {
                                        getMemberRecord.IsActive = false;
                                        getTransactionRecord.MembershipEndDate = DateTime.Today.Date;
                                        getTransactionRecord.DisFellowshipReasonId = memberStatusId;
                                        getTransactionRecord.LastModifiedTime = transactionDate;
                                        getTransactionRecord.LastModifierUserId = userId;
                                        getTransactionRecord.IsActive = false;
                                    }
                                }
                            }

                            dbContext.SaveChanges();//not this 
                            UpdateRelatedDataTables(transactionDate, userId, memberId);
                            
                            var modifiedEntries = dbContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);

                            foreach (DbEntityEntry entity in modifiedEntries)
                            {
                                foreach (var propName in entity.CurrentValues.PropertyNames)
                                {
                                    var current = entity.CurrentValues[propName];
                                    var original = entity.OriginalValues[propName];
                                }
                            }

                            //dbContext.SaveChanges(); use this save 
                        }

                        e.Result = "Transaction Saved";
                    }

                    transcope.Complete();
                }
            }

            getSaveMembers();
        }

        private void getSaveMembers()
        {
            memberList = new List<Member>();
            memberAttachments = new List<MemberAttachment>();
            diaryNotes = new List<DiaryNotes>();
            memberAttachments = dbContext.MemberAttachments.AsNoTracking().ToList();
            memberList = dbContext.Members.AsNoTracking().ToList();
            diaryNotes = dbContext.DiaryNotes.Where(x=> x.MemberId > 0).AsNoTracking().ToList();
        }

        private void UpdateRelatedDataTables(DateTime transactionDate, int userId, int memberId)
        {
            foreach (var row in grdNOKDataDisplay.Rows.Where(x => x.Cells["FirstName0"].Value != null).ToList())
            {
                var firstName = row.Cells["FirstName0"].Value.ToString().Trim();
                var lastName = row.Cells["LastName0"].Value;
                var relTypeId = Convert.ToInt16(row.Cells["NOKRelType"].Value);
                var hPhone = row.Cells["HomePhone"].Value;
                var cPhone = row.Cells["CellPhone"].Value;
                var oPhone = row.Cells["WorkPhone"].Value;
                var notes = row.Cells["Notes"].Value;
                var nokId = row.Cells["MemberNextOfKinId"].Value;

                if (nokId == null || Convert.ToInt32(nokId) == 0)
                {
                    MemberNextOfKin nextOfKin = new MemberNextOfKin();
                    nextOfKin.CellPhone = cPhone == null || cPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : cPhone.ToString();
                    nextOfKin.CreationTime = transactionDate;
                    nextOfKin.CreatorUserId = userId;
                    nextOfKin.FirstName = firstName;
                    nextOfKin.HomePhone = hPhone == null || hPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : hPhone.ToString();
                    nextOfKin.LastName = lastName == null ? "" : lastName.ToString().Trim();
                    nextOfKin.MemberId = memberId;
                    nextOfKin.Notes = notes == null ? " " : notes.ToString().Trim();
                    nextOfKin.RelationTypeId = relTypeId;
                    nextOfKin.WorkPhone = oPhone == null || oPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : oPhone.ToString();
                    dbContext.MemberNextOfKins.Add(nextOfKin);
                }
                else
                {
                    var getNOKRecord = dbContext.MemberNextOfKins.Where(x => x.MemberNextOfKinId == (int)nokId).FirstOrDefault();
                    getNOKRecord.CellPhone = cPhone == null || cPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : cPhone.ToString();
                    getNOKRecord.FirstName = firstName;
                    getNOKRecord.HomePhone = hPhone == null || hPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : hPhone.ToString();
                    getNOKRecord.LastModifiedTime = transactionDate;
                    getNOKRecord.LastModifierUserId = userId;
                    getNOKRecord.LastName = lastName == null ? "" : lastName.ToString().Trim();
                    getNOKRecord.Notes = notes == null ? " " : notes.ToString().Trim();
                    getNOKRecord.RelationTypeId = relTypeId;
                    getNOKRecord.WorkPhone = oPhone == null || oPhone.ToString().Trim() == string.Empty ? "(___)-___-____" : oPhone.ToString();
                }
            }

            foreach (var row in grdPostDisplay.Rows.Where(x => x.Cells["Post"].Value != null).ToList())
            {
                short postId = Convert.ToInt16(row.Cells["Post"].Value);
                DateTime startDate = Convert.ToDateTime(row.Cells["StartDate"].Value);
                var memberPostId = row.Cells["MemberPostId"].Value;
                var endDate = row.Cells["EndDate"].Value;

                if (memberPostId == null || Convert.ToInt32(memberPostId) == 0)
                {
                    MemberPost memberPost = new MemberPost();
                    memberPost.CreationTime = transactionDate;
                    memberPost.CreatorUserId = userId;
                    memberPost.MemberId = memberId;
                    memberPost.StartDate = startDate;
                    memberPost.PostId = postId;
                    dbContext.MemberPosts.Add(memberPost);
                }
                else
                {
                    var getMemberPost = dbContext.MemberPosts.Where(x => x.MemberPostId == (int)memberPostId).FirstOrDefault();
                    getMemberPost.LastModifiedTime = transactionDate;
                    getMemberPost.LastModifierUserId = userId;
                    getMemberPost.PostId = postId;
                    getMemberPost.StartDate = startDate;
                    getMemberPost.EndDate = endDate == null ? null : (DateTime?)endDate;
                }
            }

            foreach (var row in grdAnniversaryDisplay.Rows.Where(x => x.Cells["AnniversaryType"].Value != null).ToList())
            {
                short anniversaryTypeId = Convert.ToInt16(row.Cells["AnniversaryType"].Value);
                DateTime anniversaryDate = Convert.ToDateTime(row.Cells["AnniversaryDate"].Value);
                var memberAnniversaryId = row.Cells["MemberAnniversaryId"].Value;

                if (memberAnniversaryId == null || Convert.ToInt32(memberAnniversaryId) == 0)
                {
                    MemberAnniversary anniversary = new MemberAnniversary();
                    anniversary.CreationTime = transactionDate;
                    anniversary.CreatorUserId = userId;
                    anniversary.MemberId = memberId;
                    anniversary.AnniversaryDate = anniversaryDate;
                    anniversary.AnniversaryTypeId = anniversaryTypeId;
                    anniversary.IsActive = true;
                    dbContext.MemberAnniversaries.Add(anniversary);
                }
                else
                {
                    var getMemberAnniversary = dbContext.MemberAnniversaries.Where(x => x.MemberAnniversaryId == (int)memberAnniversaryId).FirstOrDefault();
                    getMemberAnniversary.LastModifiedTime = transactionDate;
                    getMemberAnniversary.LastModifierUserId = userId;
                    getMemberAnniversary.AnniversaryTypeId = anniversaryTypeId;
                    getMemberAnniversary.AnniversaryDate = anniversaryDate;
                }
            }

            foreach (var rows in grdEducationDisplay.Rows.Where(x => x.Cells["InstitutionName"].Value != null && x.Cells["QualificationLevel"].Value != null).ToList())
            {
                var institutionName = rows.Cells["InstitutionName"].Value;
                short qualificationLevelId = Convert.ToInt16(rows.Cells["QualificationLevel"].Value);
                var qualificationName = rows.Cells["QualificationName"].Value;
                var memberEducationId = rows.Cells["MemberEducationId"].Value;

                if (memberEducationId == null || Convert.ToInt32(memberEducationId) == 0)
                {
                    MemberEducation memberEducation = new MemberEducation();
                    memberEducation.CreationTime = transactionDate;
                    memberEducation.CreatorUserId = userId;
                    memberEducation.MemberId = memberId;
                    memberEducation.QualificationName = qualificationName.ToString().Trim();
                    memberEducation.InstitutionName = institutionName.ToString().Trim();
                    memberEducation.EducationLevelId = qualificationLevelId;
                    dbContext.MemberEducations.Add(memberEducation);
                }
                else
                {
                    var getMemberEducation = dbContext.MemberEducations.Where(x => x.MemberEducationId == (int)memberEducationId).FirstOrDefault();
                    getMemberEducation.LastModifiedTime = transactionDate;
                    getMemberEducation.LastModifierUserId = userId;
                    getMemberEducation.QualificationName = qualificationName.ToString().Trim();
                    getMemberEducation.InstitutionName = institutionName.ToString().Trim();
                    getMemberEducation.EducationLevelId = qualificationLevelId;
                }
            }

            foreach (var rows in grdSkillsDisplay.Rows.Where(x => x.Cells["SkillName"].Value != null && x.Cells["SkillLevel"].Value != null).ToList())
            {
                short skillId = Convert.ToInt16(rows.Cells["SkillName"].Value);
                short levelId = Convert.ToInt16(rows.Cells["SkillLevel"].Value);
                var memberSkillId = rows.Cells["MemberSkillId"].Value;

                if (memberSkillId == null || Convert.ToInt32(memberSkillId) == 0)
                {
                    MemberSkill skill = new MemberSkill();
                    skill.MemberId = memberId;
                    skill.SkillId = skillId;
                    skill.SkillLevelId = levelId;
                    skill.CreatorUserId = userId;
                    skill.CreationTime = transactionDate;
                    skill.IsActive = true;
                    dbContext.MemberSkills.Add(skill);
                }
                else
                {
                    var getMemberSkill = dbContext.MemberSkills.Where(x => x.MemberSkillId == (int)memberSkillId).FirstOrDefault();
                    getMemberSkill.LastModifiedTime = transactionDate;
                    getMemberSkill.LastModifierUserId = userId;
                    getMemberSkill.SkillLevelId = levelId;
                }
            }

            foreach (var rows in grdRelationDisplay.Rows.Where(x => x.Cells["RelType"].Value != null && x.Cells["MemberId1"].Value != null).ToList())
            {
                short relTypeId = Convert.ToInt16(rows.Cells["RelType"].Value);
                int relatedMemberId = Convert.ToInt32(rows.Cells["MemberId1"].Value);
                var memberRelationId = rows.Cells["MemberRelationId"].Value;

                if (memberRelationId == null || Convert.ToInt32(memberRelationId) == 0)
                {
                    MemberRelation relation = new MemberRelation();
                    relation.CreationTime = transactionDate;
                    relation.CreatorUserId = userId;
                    relation.MemberId = memberId;
                    relation.RelatedMemberId = relatedMemberId;
                    relation.RelationTypeId = relTypeId;
                    dbContext.MemberRelations.Add(relation);
                }
                else
                {
                    var getMemberRelation = dbContext.MemberRelations.Where(x => x.MemberRelationId == (int)memberRelationId).FirstOrDefault();
                    getMemberRelation.LastModifiedTime = transactionDate;
                    getMemberRelation.LastModifierUserId = userId;
                    getMemberRelation.RelatedMemberId = relatedMemberId;
                    getMemberRelation.RelationTypeId = relTypeId;
                }
            }

            if (radBrowseEditor.Value != null)
            {
                byte[] imageData;

                string fileName = radBrowseEditor.Value.ToString();
                FileStream fs = File.OpenRead(fileName);
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);

                MemberAttachment attachment = new MemberAttachment();
                attachment.Attachment = imageData;
                attachment.AttachmentName = txtImageName.Text.Trim();
                attachment.CreationTime = transactionDate;
                attachment.CreatorUserId = userId;
                attachment.MemberId = memberId;
                dbContext.MemberAttachments.Add(attachment);
            }

            dbContext.SaveChanges();
        }

        private void bgwMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bindingSourceMember.DataSource = memberList;
            memberDefinition = new List<MemberDefinition>();

            foreach (var member in memberList.Where(x => x.FirstName != null))
                memberDefinition.Add(new MemberDefinition { memberId = member.MemberId, memberName = member.FirstName.Trim() + " " + member.LastName.Trim() });

            bindingSourceRelatingMember.DataSource = memberDefinition;

            _uIManager.SetNotBusy();

            if (e.Result != null && e.Result.ToString() == "Transaction Saved")
            {
                ManipulateFormControls("", false);
                RadMessageBox.Show("Member transaction committed successfully!", Application.ProductName);
            }

            MemoryManagement.FlushMemory();
        }

        private void btnRelationAdd_Click(object sender, EventArgs e)
        {
            if (ddlMember.SelectedValue != null && ddlRelationType.SelectedValue != null)
            {
                int memberId = Convert.ToInt32(ddlMember.SelectedValue);
                short relationTypeId = Convert.ToInt16(ddlRelationType.SelectedValue);

                var getmemberRow = grdRelationDisplay.Rows.Where(x => Convert.ToInt32(x.Cells["MemberId1"].Value) == memberId).FirstOrDefault();

                if (getmemberRow == null)
                {
                    var getMemberDetails = memberList.Where(x => x.MemberId == memberId).FirstOrDefault();

                    if (getMemberDetails != null)                    
                        grdRelationDisplay.Rows.Add(getMemberDetails.MemberNo.Trim(), getMemberDetails.FirstName.Trim(), getMemberDetails.LastName.Trim(), relationTypeId, memberId, 0);                                      
                }
                else                
                    getmemberRow.Cells["RelType"].Value = relationTypeId;

                ddlMember.SelectedIndex = -1;
                ddlRelationType.SelectedIndex = -1;
                ddlMember.Enabled = true;
            }
        }

        private void grdRelationDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("RelEdit"))
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to edit this relationship?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    short relationId = Convert.ToInt16(e.Row.Cells["RelType"].Value);
                    int memberId = Convert.ToInt32(e.Row.Cells["MemberId1"].Value);

                    ddlMember.SelectedValue = memberId;
                    ddlRelationType.SelectedValue = relationId;
                    ddlMember.Enabled = false;
                }
            }
            else if (e.Column.Name.Trim().Equals("RelDelete"))
            {
                int relationId = Convert.ToInt32(e.Row.Cells["MemberRelationId"].Value);

                if (relationId > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var memberRelation = dbContext.MemberRelations.Where(x => x.MemberRelationId == relationId).FirstOrDefault();

                        if (memberRelation != null)
                        {
                            dbContext.MemberRelations.Remove(memberRelation);
                            dbContext.SaveChanges();

                            grdRelationDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var _enabledTextBoxes = this.tableLayoutPanel1.Controls.OfType<RadTextBox>().Where(x => x.Enabled == true).ToList();
            
            if (((Member)bindingSourceMember.Current).MemberId == 0 || _enabledTextBoxes.Count > 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this member's record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == DialogResult.No)
                return;

            int memberId = ((Member)bindingSourceMember.Current).MemberId;

            if (((Member)bindingSourceMember.Current).IsActive)
            {
                bindingSourceRelatingMember.DataSource = memberDefinition.Where(x => x.memberId != memberId).ToList();

                ManipulateFormControls("Edit", true);

                dtpEndDate.NullText = "Null";
                dtpEndDate.SetToNullValue();
            }
            else
                btnRejoin.Enabled = true;
        }

        private void btnEducationAdd_Click(object sender, EventArgs e)
        {
            if (ddlInstitution.SelectedValue != null && ddlEducationLevel.SelectedValue != null && txtQualification.Text.Trim() != string.Empty)
            {
                string institutionName = ddlInstitution.SelectedValue.ToString().Trim();
                short educationLevelId = Convert.ToInt16(ddlEducationLevel.SelectedValue);
                string quailifcationName = txtQualification.Text.Trim();

                var getEducationRow = grdEducationDisplay.Rows.Where(x => x.Cells["InstitutionName"].Value.ToString() == institutionName
                                      /*&& x.Cells["QualificationName"].Value.ToString() == quailifcationName*/
                                      && Convert.ToInt16(x.Cells["QualificationLevel"].Value) == educationLevelId).FirstOrDefault();

                if (getEducationRow == null)                
                    grdEducationDisplay.Rows.Add(institutionName, educationLevelId, quailifcationName, 0, 0);
                else
                    getEducationRow.Cells["QualificationName"].Value = quailifcationName;

                ddlInstitution.SelectedIndex = -1;
                ddlEducationLevel.SelectedIndex = -1;
                txtQualification.Text = string.Empty;

                ddlInstitution.Enabled = true;
                ddlEducationLevel.Enabled = true;
            }
            else
                RadMessageBox.Show("All three fields must be populated with data!", Application.ProductName);
        }

        private void btnSkillsAdd_Click(object sender, EventArgs e)
        {
            if (ddlSkillName.SelectedValue != null && ddlSkillLevel.SelectedValue != null)
            {
                short skillNameId = Convert.ToInt16(ddlSkillName.SelectedValue);
                short skillLevelId = Convert.ToInt16(ddlSkillLevel.SelectedValue);

                var getSkillRow = grdSkillsDisplay.Rows.Where(x => Convert.ToInt16(x.Cells["SkillName"].Value) == skillNameId).FirstOrDefault();

                if (getSkillRow == null)               
                    grdSkillsDisplay.Rows.Add(skillNameId, skillLevelId, true, 0, 0);                
                else
                    getSkillRow.Cells["SkillLevel"].Value = skillLevelId;

                ddlSkillName.SelectedIndex = -1;
                ddlSkillLevel.SelectedIndex = -1;
                ddlSkillName.Enabled = true;
            }
        }

        private void grdSkillsDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("SkillEdit"))
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to edit this skill record?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    short skillId = Convert.ToInt16(e.Row.Cells["SkillName"].Value);
                    short levelId = Convert.ToInt16(e.Row.Cells["SkillLevel"].Value);

                    ddlSkillName.SelectedValue = skillId;
                    ddlSkillLevel.SelectedValue = levelId;
                    ddlSkillName.Enabled = false;
                }
            }
            else if (e.Column.Name.Trim().Equals("SkillDelete"))
            {
                int id = Convert.ToInt32(e.Row.Cells["MemberSkillId"].Value);

                if (id > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var record = dbContext.MemberSkills.Where(x => x.MemberSkillId == id).FirstOrDefault();

                        if (record != null)
                        {
                            dbContext.MemberSkills.Remove(record);
                            dbContext.SaveChanges();

                            grdSkillsDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void btnPostAdd_Click(object sender, EventArgs e)
        {
            if (ddlPostName.SelectedValue != null)
            {
                short postNameId = Convert.ToInt16(ddlPostName.SelectedValue);
                DateTime effectiveDate = dtpEffectiveDate.Value;
                DateTime endDate = dtpEndDate.Value;

                var getPostRow = grdPostDisplay.Rows.Where(x => Convert.ToInt16(x.Cells["Post"].Value) == postNameId).FirstOrDefault();

                if (getPostRow == null || (getPostRow != null && getPostRow.Cells["EndDate"].Value != null))
                    grdPostDisplay.Rows.Add(postNameId, effectiveDate, null, 0, 0);
                else
                {
                    if (endDate.Year > 1)
                        getPostRow.Cells["EndDate"].Value = endDate;
                    
                    getPostRow.Cells["StartDate"].Value = effectiveDate;
                }

                ddlPostName.SelectedIndex = -1;
                dtpEffectiveDate.Value = DateTime.Today.Date;
                ddlPostName.Enabled = true;
            }
        }

        private void grdPostDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("PostEdit"))
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to edit this Post record?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    short postId = Convert.ToInt16(e.Row.Cells["Post"].Value);
                    DateTime startDate = Convert.ToDateTime(e.Row.Cells["StartDate"].Value);
                    var endValue = e.Row.Cells["EndDate"].Value;

                    if (endValue != null)
                    {
                        RadMessageBox.Show("This record cannot be editted!", Application.ProductName);
                        return;
                    }

                    ddlPostName.SelectedValue = postId;
                    dtpEffectiveDate.Value = startDate;
                    ddlPostName.Enabled = false;
                }
            }
            else if (e.Column.Name.Trim().Equals("PostDelete"))
            {
                int id = Convert.ToInt32(e.Row.Cells["MemberPostId"].Value);

                if (id > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var record = dbContext.MemberPosts.Where(x => x.MemberPostId == id).FirstOrDefault();

                        if (record != null)
                        {
                            dbContext.MemberPosts.Remove(record);
                            dbContext.SaveChanges();

                            grdPostDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void btnAnniversaryAdd_Click(object sender, EventArgs e)
        {
            if (ddlAnniversary.SelectedValue != null)
            {
                short anniversaryId = Convert.ToInt16(ddlAnniversary.SelectedValue);
                DateTime effectiveDate = dtpAnniversary.Value;

                var getAnniversaryRow = grdAnniversaryDisplay.Rows.Where(x => Convert.ToInt16(x.Cells["AnniversaryType"].Value) == anniversaryId).FirstOrDefault();

                if (getAnniversaryRow == null)
                    grdAnniversaryDisplay.Rows.Add(anniversaryId, effectiveDate, true, 0, 0);
                else
                    getAnniversaryRow.Cells["AnniversaryDate"].Value = effectiveDate;

                ddlAnniversary.SelectedIndex = -1;
                dtpAnniversary.Value = DateTime.Today.Date;
                ddlAnniversary.Enabled = true;
            }
        }
        
        private void grdAnniversaryDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("AnnEdit"))
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to edit this Anniversary record?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    short anniversaryId = Convert.ToInt16(e.Row.Cells["AnniversaryType"].Value);
                    DateTime startDate = Convert.ToDateTime(e.Row.Cells["AnniversaryDate"].Value);

                    ddlAnniversary.SelectedValue = anniversaryId;
                    dtpAnniversary.Value = startDate;
                    ddlAnniversary.Enabled = false;
                }
            }
            else if (e.Column.Name.Trim().Equals("AnnDelete"))
            {
                int id = Convert.ToInt32(e.Row.Cells["MemberAnniversaryId"].Value);

                if (id > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var record = dbContext.MemberAnniversaries.Where(x => x.MemberAnniversaryId == id).FirstOrDefault();

                        if (record != null)
                        {
                            dbContext.MemberAnniversaries.Remove(record);
                            dbContext.SaveChanges();

                            grdAnniversaryDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void dtpEffectiveDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpEffectiveDate.Value;
        }

        private void grdAttachmentDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Row.Cells["MemberAttachmentId"].Value != null && Convert.ToInt32(e.Row.Cells["MemberAttachmentId"].Value) > 0)
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to delete this Attachment?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    int attachmentId = Convert.ToInt32(e.Row.Cells["MemberAttachmentId"].Value);

                    var attachment = dbContext.MemberAttachments.Where(x => x.MemberAttachmentId == attachmentId).FirstOrDefault();

                    if (attachment != null)
                    {
                        dbContext.MemberAttachments.Remove(attachment);
                        dbContext.SaveChanges();

                        var getImageFromBindingsource = memberAttachments.Where(x => x.MemberAttachmentId == attachmentId).FirstOrDefault();

                        if (getImageFromBindingsource != null)
                            memberAttachments.Remove(getImageFromBindingsource);
                    }
                }
            }
        }

        private void grdAttachmentDisplay_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            var imageBytes = e.Row.Cells["Attachment"].Value;

            if (imageBytes != null)
            {
                int attachmentId = Convert.ToInt32(e.Row.Cells["MemberAttachmentId"].Value);
                List<MemberAttachment> attachments = new List<MemberAttachment>();
                attachments = memberAttachments.Where(x => x.MemberAttachmentId == attachmentId).ToList();
                
                FrmImageZoom imageZoom = new FrmImageZoom(attachments);
                imageZoom.ShowDialog();
            }
        }

        private void btnRejoin_Click(object sender, EventArgs e)
        {
            int memberId = ((Member)bindingSourceMember.Current).MemberId;
            string memberName = ((Member)bindingSourceMember.Current).FirstName.Trim() + " " + ((Member)bindingSourceMember.Current).LastName.Trim();
            int userId = _userInfo.UserId;

            if (memberId > 0)
            {
                FrmAdmit admitMember = new FrmAdmit(memberId, memberName, userId);
                admitMember.ShowDialog();

                btnRejoin.Enabled = false;
                bgwMember.RunWorkerAsync();
                _uIManager.SetBusy(radGroupBox2);
            }
        }

        private void btnEndMembership_Click(object sender, EventArgs e)
        {
            int memberId = ((Member)bindingSourceMember.Current).MemberId;
            string memberName = ((Member)bindingSourceMember.Current).FirstName.Trim() + " " + ((Member)bindingSourceMember.Current).LastName.Trim();
            int userId = _userInfo.UserId;

            if (memberId > 0)
            {
                FrmDisfellowship disfellowship = new FrmDisfellowship(memberId, memberName, userId);
                disfellowship.ShowDialog();

                ManipulateFormControls("Edit", false);
                btnRejoin.Enabled = false;
                btnEndMembership.Enabled = false;
                bgwMember.RunWorkerAsync();
                _uIManager.SetBusy(radGroupBox2);
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (grdData.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("All unsaved data will be lost.\n" +
                                                            "Are you sure you want to revert?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == DialogResult.Yes)
            {
                ManipulateFormControls("", false);

                int _memberId = ((Member)bindingSourceMember.Current).MemberId;

                if (_memberId == 0)
                    bindingSourceMember.RemoveCurrent();
                else
                    bindingSourceMember.MovePrevious();
            }
        }

        private void grdEducationDisplay_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("EducationEdit"))
            {
                DialogResult promptUser = RadMessageBox.Show("Are you sure you want to edit this Education record?", Application.ProductName, MessageBoxButtons.YesNo);

                if (promptUser == DialogResult.Yes)
                {
                    short levelId = Convert.ToInt16(e.Row.Cells["QualificationLevel"].Value);
                    var institutionName = e.Row.Cells["InstitutionName"].Value;

                    if (institutionName != null)
                    {
                        ddlEducationLevel.SelectedValue = levelId;
                        ddlInstitution.Items.IndexOf(ddlInstitution.Items.First(x => x.Text == institutionName.ToString()));
                        //ddlInstitution.Value = institutionName;
                        ddlInstitution.Enabled = false;
                        ddlEducationLevel.Enabled = false;
                    }
                }
            }
            else if (e.Column.Name.Trim().Equals("EducationDelete"))
            {
                int id = Convert.ToInt32(e.Row.Cells["MemberEducationId"].Value);

                if (id > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var record = dbContext.MemberEducations.Where(x => x.MemberEducationId == id).FirstOrDefault();

                        if (record != null)
                        {
                            dbContext.MemberEducations.Remove(record);
                            dbContext.SaveChanges();

                            grdEducationDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdCommentary.Rows.Count > 0)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Select Path to save this export";
                folder.ShowDialog();
                string path = string.Empty;

                if (!string.IsNullOrEmpty(folder.SelectedPath))
                    path = folder.SelectedPath;
                else
                {
                    RadMessageBox.Show("A path must be selected to facilitate this export!", Application.ProductName);
                    return;
                }

                string _destinationPath = path;

                string _saveAs = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();

                string fullpath = _destinationPath + "\\" + _saveAs + ".xlsx";

                bool fileExist = File.Exists(fullpath);

                if (fileExist)
                {
                    RadMessageBox.Show("A file containing the same name already exist in this location", Application.ProductName);
                    return;
                }

                GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.grdCommentary);
                SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

                spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport;
                spreadExporter.SheetName = _saveAs;
                spreadExporter.ExportVisualSettings = true;
                spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;

                spreadExporter.RunExport(fullpath, exportRenderer);

                RadMessageBox.Show("File exported successfully!", Application.ProductName);
            }
        }

        private void grdCommentary_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Trim().Equals("deleteComment"))
            {
                int id = Convert.ToInt32(e.Row.Cells["MemberAnniversaryId"].Value);

                if (id > 0)
                {
                    DialogResult prompt = RadMessageBox.Show("This process will remove the record permanently" + Environment.NewLine +
                                                             "If you continue, the process cannot be undone" + Environment.NewLine +
                                                             "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo,
                                                             RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

                    if (prompt == DialogResult.Yes)
                    {
                        var record = dbContext.DiaryNotes.Where(x => x.DiaryNotesId == id).FirstOrDefault();

                        if (record != null)
                        {
                            dbContext.DiaryNotes.Remove(record);
                            dbContext.SaveChanges();

                            grdCommentary.Refresh();
                        }
                    }
                }
            }
        }
    }
}