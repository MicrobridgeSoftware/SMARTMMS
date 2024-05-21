using Mbridge.Common.Application.Authorization.Users.Dto;
using Mbridge.Common.Persistence.Shared;
using Mbridge.Common.Presentation.Forms;
using Mbridge.Common.Presentation.Forms.Authorization.ChangePassword;
using Mbridge.Common.Presentation.Forms.Authorization.Login;
using Mbridge.SMARTMMS.Persistence;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SMARTMMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = Container.For<MMSRegistry>();

            container.Configure(c =>
            c.For(typeof(StructureMap.IContainer)).Use(container)
            );

            var loginForm = container.GetInstance<LoginForm>();


            Application.Run(loginForm);

            var result = loginForm.DialogResult;

            if (result == DialogResult.OK)
            {
                var userInfo = container.GetInstance<UserInfo>();

                if (userInfo.ShouldPasswordChangeOnNextLogin)
                {
                    var changePasswordForm = container.GetInstance<ChangePasswordForm>();
                    result = changePasswordForm.ShowDialog();

                    if (result != DialogResult.OK)
                        Application.Exit();

                }

                var mainForm = container.GetInstance<SMARTMMS.Forms.MainForm>();
                 Application.Run(mainForm);

            }

        }


        public class MMSRegistry : Registry
        {
            public MMSRegistry()
            {
                Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.AssembliesFromApplicationBaseDirectory();
                    For<DatabaseContext>().Use(() => new MMSDbContext());
                    For(typeof(IConnectedRepository<>)).Use(typeof(ConnectedRepository<>));
                    For(typeof(IDisconnectedRepository<>)).Use(typeof(DisconnectedRepository<>));

                });
                // requires explicit registration; doesn't follow convention
                // For(typeof(StructureMap.IContainer)).Use(Container.For<MMSRegistry>());
                For<UserInfo>().Singleton();
            }
        }
    }
}