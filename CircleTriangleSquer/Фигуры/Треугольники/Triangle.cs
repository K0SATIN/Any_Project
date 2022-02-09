/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 24.12.2021
 * Время: 13:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Тестовое_4
{
	/// <summary>
	/// Description of Triangle.
	/// </summary>
	/// 
	
	public interface I_AnyTriangleSquare
	{
		double IGetSquareOnEdges(int a, int b, int c);
	}

	public abstract class TriangleChecker : InputChecer
	{
		public bool IsRightTriangleOnEdges(int a, int b, int c)//метод поверяет на прямоугольность 
		{
			bool IsRightTriangleValue;
			if ((a*a == b*b+c*c)||(b*b == a*a+c*c)||(c*c == a*a+b*b))
				IsRightTriangleValue =  true;
			else 
				IsRightTriangleValue = false;
			return IsRightTriangleValue;
		}
	}
	
	public class GetSquareOnEdges: I_AnyTriangleSquare
	{
		public double IGetSquareOnEdges(int a, int b, int c)
		{
			double p = (a+b+c)/2; //возврат площади по формуле Герона, но нужно знать 3 стороны
			return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
		}
	}
	
	public class Triangle: TriangleChecker, I_shape
	{
		int a, b, c;
		public I_AnyTriangleSquare AnyTriangleSquare {get; set;}
		
		public Triangle(int a, int b, int c)
		{
			this.a = CheckIntEdge(a); 
			this.b = CheckIntEdge(b);
			this.c = CheckIntEdge(c);
			if ((this.a+this.b<=this.c)||(this.c+this.b<=this.a)||(this.a+this.c<=this.b))
				throw new Exception("Одна из сторон больше двух других");
		}
		
		public string I_shapeName
    	{
        	get
        	{
            	return "Треугольник";    // возвращаем значение свойства
        	}
        	set {}
    	} 

		public double GetI_shapeSquare()//метод возвращающий площадь. 
		{
			return AnyTriangleSquare.IGetSquareOnEdges(a, b, c);
		}
				
		public bool IsRightTriangle()//метод поверяет на прямоугольность 
		{
			return IsRightTriangleOnEdges(a, b, c); 			
		}	
	}
	
	
}
