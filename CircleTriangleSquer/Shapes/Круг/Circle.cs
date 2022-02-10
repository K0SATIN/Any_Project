/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 24.12.2021
 * Время: 13:42
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Тестовое_4
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	/// 
		
	public interface ICircleSquare 
	{
		double GetI_shapeSquare(int i);
	}
	
	class CircleSquareR : AllConstant, ICircleSquare
	{
		public double GetI_shapeSquare(int r)
		{
			return pi*r*r;
		}	
	}
		
	class CircleSquareD : AllConstant, ICircleSquare
	{
		public double GetI_shapeSquare(int d)
		{
			return pi*d*d/4;
		}	
	}
	
	public class Circle: InputChecer, I_shape
	{
		int r;
		public ICircleSquare CircleSquare{get; set;}
		public Circle(int r)
		{
			this.r =  CheckIntEdge(r);
		}
		public string I_shapeName
    	{
        	get
        	{
            	return "круг";    // возвращаем значение свойства
        	}
        	set {}
    	}		
		public double GetI_shapeSquare()
		{
			return CircleSquare.GetI_shapeSquare(r);
		}
		
	}
}
