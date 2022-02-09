/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 24.12.2021
 * Время: 13:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Тестовое_4
{
	/// <summary>
	/// Description of CommonInterface.
	/// </summary>
	/// 
	
	public interface I_shape 
	{//соглашение о свойствах и методах, которые должны быть реализованы в каждом объекте индивидуально
		string I_shapeName { get; set; }
		double GetI_shapeSquare();
	}
}
