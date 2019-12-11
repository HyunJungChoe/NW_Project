using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace MultiChatClient {
    static class Program {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 채팅 폼
            // Application.Run(new ChatForm());
            Application.Run(new ChatForm2());

            //로그인 폼
            //Application.Run(new Login());
        }
    }
}
