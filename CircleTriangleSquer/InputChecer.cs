/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 24.12.2021
 * Время: 13:17
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Тестовое_4
{
	/// <summary>
	/// Description of CommonClass.
	/// </summary>
	public abstract class InputChecer
	{
		public int CheckIntEdge(int a)
		{//вместо проверки на отрицательность берём по модулю
			return Math.Abs(a); 
		}
	}
}
