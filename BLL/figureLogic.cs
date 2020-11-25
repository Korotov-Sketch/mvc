using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace BLL
{
    public class FigureLogic
    {
		private IFigureDAO fig;
		public FigureLogic(IFigureDAO fig)
		{
			this.fig = fig;
		}
		public FigureLogic()
		{
			fig = new FigureDAO();
		}
		public List<Function> input()
		{
			return fig.input();
		}

	}
}
