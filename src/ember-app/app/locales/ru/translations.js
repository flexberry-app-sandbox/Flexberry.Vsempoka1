import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISVsempokaДокумПоставLForm from './forms/i-i-s-vsempoka-докум-постав-l';
import IISVsempokaКлиентыLForm from './forms/i-i-s-vsempoka-клиенты-l';
import IISVsempokaОрганизацияLForm from './forms/i-i-s-vsempoka-организация-l';
import IISVsempokaПунктПогрузкиLForm from './forms/i-i-s-vsempoka-пункт-погрузки-l';
import IISVsempokaСписокБаржLForm from './forms/i-i-s-vsempoka-список-барж-l';
import IISVsempokaСписокКонтейLForm from './forms/i-i-s-vsempoka-список-контей-l';
import IISVsempokaТоварыLForm from './forms/i-i-s-vsempoka-товары-l';
import IISVsempokaФормирДокРаспрLForm from './forms/i-i-s-vsempoka-формир-док-распр-l';
import IISVsempokaФормирРезПосLForm from './forms/i-i-s-vsempoka-формир-рез-пос-l';
import IISVsempokaДокумПоставEForm from './forms/i-i-s-vsempoka-докум-постав-e';
import IISVsempokaКлиентыEForm from './forms/i-i-s-vsempoka-клиенты-e';
import IISVsempokaОрганизацияEForm from './forms/i-i-s-vsempoka-организация-e';
import IISVsempokaПунктПогрузкиEForm from './forms/i-i-s-vsempoka-пункт-погрузки-e';
import IISVsempokaСписокБаржEForm from './forms/i-i-s-vsempoka-список-барж-e';
import IISVsempokaСписокКонтейEForm from './forms/i-i-s-vsempoka-список-контей-e';
import IISVsempokaТоварыEForm from './forms/i-i-s-vsempoka-товары-e';
import IISVsempokaФормирДокРаспрEForm from './forms/i-i-s-vsempoka-формир-док-распр-e';
import IISVsempokaФормирРезПосEForm from './forms/i-i-s-vsempoka-формир-рез-пос-e';
import IISVsempokaДокумПоставModel from './models/i-i-s-vsempoka-докум-постав';
import IISVsempokaИнфорОЗаказеModel from './models/i-i-s-vsempoka-инфор-о-заказе';
import IISVsempokaКлиентыModel from './models/i-i-s-vsempoka-клиенты';
import IISVsempokaОрганизацияModel from './models/i-i-s-vsempoka-организация';
import IISVsempokaПунктПогрузкиModel from './models/i-i-s-vsempoka-пункт-погрузки';
import IISVsempokaСписокБаржModel from './models/i-i-s-vsempoka-список-барж';
import IISVsempokaСписокКонтейModel from './models/i-i-s-vsempoka-список-контей';
import IISVsempokaТоварыModel from './models/i-i-s-vsempoka-товары';
import IISVsempokaФормирДокРаспрModel from './models/i-i-s-vsempoka-формир-док-распр';
import IISVsempokaФормирРезПосModel from './models/i-i-s-vsempoka-формир-рез-пос';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-vsempoka-докум-постав': IISVsempokaДокумПоставModel,
    'i-i-s-vsempoka-инфор-о-заказе': IISVsempokaИнфорОЗаказеModel,
    'i-i-s-vsempoka-клиенты': IISVsempokaКлиентыModel,
    'i-i-s-vsempoka-организация': IISVsempokaОрганизацияModel,
    'i-i-s-vsempoka-пункт-погрузки': IISVsempokaПунктПогрузкиModel,
    'i-i-s-vsempoka-список-барж': IISVsempokaСписокБаржModel,
    'i-i-s-vsempoka-список-контей': IISVsempokaСписокКонтейModel,
    'i-i-s-vsempoka-товары': IISVsempokaТоварыModel,
    'i-i-s-vsempoka-формир-док-распр': IISVsempokaФормирДокРаспрModel,
    'i-i-s-vsempoka-формир-рез-пос': IISVsempokaФормирРезПосModel
  },

  'application-name': 'Vsempoka',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Vsempoka',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Vsempoka',
          title: 'Vsempoka'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        логистика: {
          caption: 'Логистика',
          title: 'Логистика',
          'i-i-s-vsempoka-клиенты-l': {
            caption: 'Клиенты',
            title: ''
          },
          'данные-об-организации': {
            caption: 'Данные об организации',
            title: 'Данные об организации',
            'i-i-s-vsempoka-организация-l': {
              caption: 'Организация',
              title: 'Организация'
            },
            'i-i-s-vsempoka-пункт-погрузки-l': {
              caption: 'Пункт погрузки',
              title: 'Пункт погрузки'
            },
            'i-i-s-vsempoka-список-барж-l': {
              caption: 'Список барж',
              title: 'Список барж'
            },
            'i-i-s-vsempoka-список-контей-l': {
              caption: 'Список контейнеров',
              title: 'Список контей'
            }
          },
          номенклатура: {
            caption: 'Номенклатура',
            title: 'Номенклатура',
            'i-i-s-vsempoka-товары-l': {
              caption: 'Товары',
              title: 'Товары'
            }
          },
          документы: {
            caption: 'Документы',
            title: 'Документы',
            'i-i-s-vsempoka-формир-рез-пос-l': {
              caption: 'Формирование результата поставки',
              title: 'Формир рез пос'
            },
            'i-i-s-vsempoka-докум-постав-l': {
              caption: 'Докум поставки',
              title: 'Докум постав'
            },
            'i-i-s-vsempoka-формир-док-распр-l': {
              caption: 'Формирование документа распределения',
              title: 'Формир док распр'
            }
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-vsempoka-докум-постав-l': IISVsempokaДокумПоставLForm,
    'i-i-s-vsempoka-клиенты-l': IISVsempokaКлиентыLForm,
    'i-i-s-vsempoka-организация-l': IISVsempokaОрганизацияLForm,
    'i-i-s-vsempoka-пункт-погрузки-l': IISVsempokaПунктПогрузкиLForm,
    'i-i-s-vsempoka-список-барж-l': IISVsempokaСписокБаржLForm,
    'i-i-s-vsempoka-список-контей-l': IISVsempokaСписокКонтейLForm,
    'i-i-s-vsempoka-товары-l': IISVsempokaТоварыLForm,
    'i-i-s-vsempoka-формир-док-распр-l': IISVsempokaФормирДокРаспрLForm,
    'i-i-s-vsempoka-формир-рез-пос-l': IISVsempokaФормирРезПосLForm,
    'i-i-s-vsempoka-докум-постав-e': IISVsempokaДокумПоставEForm,
    'i-i-s-vsempoka-клиенты-e': IISVsempokaКлиентыEForm,
    'i-i-s-vsempoka-организация-e': IISVsempokaОрганизацияEForm,
    'i-i-s-vsempoka-пункт-погрузки-e': IISVsempokaПунктПогрузкиEForm,
    'i-i-s-vsempoka-список-барж-e': IISVsempokaСписокБаржEForm,
    'i-i-s-vsempoka-список-контей-e': IISVsempokaСписокКонтейEForm,
    'i-i-s-vsempoka-товары-e': IISVsempokaТоварыEForm,
    'i-i-s-vsempoka-формир-док-распр-e': IISVsempokaФормирДокРаспрEForm,
    'i-i-s-vsempoka-формир-рез-пос-e': IISVsempokaФормирРезПосEForm
  },

});

export default translations;
