using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm {
    public class AppState {
        private int form;
        public AppState() {
            form = 0;
        }

        public AppState(AppState st) {
            this.form = st.form;
        }
        public void navigateTo(int n) {
            this.form = n;
        }
        public int getPage() {
            return this.form;
        }
    }
}
