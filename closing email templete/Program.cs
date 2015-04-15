/*Create By Robert Willis Anderson
 * 
 * 
 * 
 * 
 * Modified 10/07/2014
 * changed up the closure email template according to Benjamin Thomas
 * also trying to make things that are for vnxe marked as vnxe since this will go out to the unified team
 * also added in Rons USD link 
 * 
 * 
 * 
 * Modifed 07/03/2014
 * made changes to the owner change template, made it so that the information is in a table using HTMl also removed sginature as it would not work with the html body and this is an internal email that doe snot need signature
 * 
 * 
 * modified 06/20/2014
 * added in performance kb article links to open
 * also added in kb articles in to ordering parts, gathering logs and performance email
 * also copies kb articles to clipboard for easy paste into service request
 * adding dispatch part template as well
 * 
 * modified on 05/23/2014
 * added kb/document links, usefully information for VNXe troubleshooting
 * added in web links that may be needed such as service site, surge site etc.
 * two links for creating your own, 1 for creating a tempalte and 1 for creating web link; still need to figure out how to allow a user to create their own and it be saved
 * also added a note section thinking of linking my notes there so that everyone can access them
 * 
 * 
 * 
 * 
 * Modified on 12-09-2013
 * recent changes added in templetes accept SR
 * 
 * changes made 12/27/2013
 * added in 2 more templates
 * 1. for code red email template
 * 2. for owner change template.
 * 
 * updated on 12/30/2013
 * added 4 more templetes
 * 1. how to upgrade
 * 2. break fix issues complete
 * 3. sp dart panic
 * 4. Also made a couple minor spelling/word changes
 * 
 * 
 * 
 * 
 * 
 * Issues/improvements wanted to be made
 * 
 * 1. Want to allow a user to create there own template to re-use
 * 2. no spellcheck.
 * 3. uses first signature in outlook.
 * 4. can open multiple templates at the same time
 *  a. want to only allow one template to be opened at a time.
 * 
 * updated 01/02/2014
 * 
 * agent name does not clear in the accept case
 * Closure eamil tabs the , after Hello customer name
 * Dial home does not clear Agent Name
 * Owner change does not change engineering/vendor section
 * Also fixed the subject of the email for owner chagne left CODE RED before SR#
 * 
 * 
 * list of templates
 * Accept Case
 * Break fix issues done
 * closure Email	
 * Code red
 * dial home/faulted part
 * gather new logs
 * how to upgrade
 * order part
 * owner change
 * performance email
 * sp panic
 * 
 * 
 * update for February 21, 2014
 * added in the new code red processes, made the code red look how it should when using the hotkey template
 * also fixed the number in the gather new logs
 * 
 * update May 14, 2014
 * update template to show new manager info
 * added in email links section and VNXe usefull links
 * added 2 buttons that do not work yet, create email template and create email link
 *need to find out how to allow users to make their own links and email templates
 * */


using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace closing_email_templete
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
        }
    }
}
