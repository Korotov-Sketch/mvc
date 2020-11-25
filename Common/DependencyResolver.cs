using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace Common
{
    public class DependencyResolver
    {
		static private IFigureDAO figuredao;
		static private FigureLogic figureLogic;
		static public IFigureDAO BaseTransport { get => figuredao ?? new FigureDAO(); }
		static public FigureLogic FigureLogic { get => figureLogic ?? new FigureLogic(figuredao); }
	}
}
