const track = document.querySelector('.carousel-track'); // Находим элемент с классом 'carousel-track', который содержит все блоки карусели
const prevButton = document.getElementById('prev'); // Находим кнопку "Назад"
const nextButton = document.getElementById('next'); // Находим кнопку "Вперед"
const items = document.querySelectorAll('.carousel-item'); // Получаем все блоки карусели

let currentIndex = 0; // Текущий индекс элемента карусели, с которого начинается показ (по умолчанию первый элемент)

// Функция для обновления состояния кнопок (включает/отключает их в зависимости от текущего индекса)
function updateButtons() {
  // Если текущий индекс 0 (мы на первом блоке), отключаем кнопку "Назад"
  if (currentIndex === 0) {
    prevButton.hidden = true;
    prevButton.disabled = true;
  } else {
    // Если не на первом блоке, включаем кнопку "Назад"
    prevButton.hidden = false;
    prevButton.disabled = false;
  }

  // Если текущий индекс последний (мы на последнем блоке), отключаем кнопку "Вперед"
  if (currentIndex === items.length - 1) {
    nextButton.hidden = true;
    nextButton.disabled = true;
  } else {
    // Если не на последнем блоке, включаем кнопку "Вперед"
    nextButton.hidden = false;
    nextButton.disabled = false;
  }
}

// Обрабатываем клик по кнопке "Вперед"
nextButton.addEventListener('click', () => {
  // Проверяем, что текущий индекс не последний (не больше чем количество блоков минус 1)
  if (currentIndex < items.length - 1) {
    currentIndex += 1; // Увеличиваем индекс на 1 (переходим к следующему блоку)
    track.style.transform = `translateX(-${currentIndex * 800}px)`; // Смещаем карусель влево на 300px для каждого следующего блока
    updateButtons(); // Обновляем состояние кнопок после перемещения
  }
});

// Обрабатываем клик по кнопке "Назад"
prevButton.addEventListener('click', () => {
  // Проверяем, что текущий индекс больше 0 (иначе нельзя двигаться назад)
  if (currentIndex > 0) {
    currentIndex -= 1; // Уменьшаем индекс на 1 (переходим к предыдущему блоку)
    track.style.transform = `translateX(-${currentIndex * 800}px)`; // Смещаем карусель вправо на 300px для каждого предыдущего блока
    updateButtons(); // Обновляем состояние кнопок после перемещения
  }
});

// При загрузке страницы сразу вызываем функцию обновления кнопок, чтобы учесть начальное положение
updateButtons();
