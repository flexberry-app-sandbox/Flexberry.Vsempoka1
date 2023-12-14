import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.логистика.caption'),
          title: i18n.t('forms.application.sitemap.логистика.title'),
          children: [{
            link: 'i-i-s-vsempoka-клиенты-l',
            caption: i18n.t('forms.application.sitemap.логистика.i-i-s-vsempoka-клиенты-l.caption'),
            title: i18n.t('forms.application.sitemap.логистика.i-i-s-vsempoka-клиенты-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: null,
            caption: i18n.t('forms.application.sitemap.логистика.данные-об-организации.caption'),
            title: i18n.t('forms.application.sitemap.логистика.данные-об-организации.title'),
            children: [{
              link: 'i-i-s-vsempoka-организация-l',
              caption: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-организация-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-организация-l.title'),
              icon: 'chart line',
              children: null
            }, {
              link: 'i-i-s-vsempoka-пункт-погрузки-l',
              caption: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-пункт-погрузки-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-пункт-погрузки-l.title'),
              icon: 'chart line',
              children: null
            }, {
              link: 'i-i-s-vsempoka-список-барж-l',
              caption: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-список-барж-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-список-барж-l.title'),
              icon: 'phone',
              children: null
            }, {
              link: 'i-i-s-vsempoka-список-контей-l',
              caption: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-список-контей-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.данные-об-организации.i-i-s-vsempoka-список-контей-l.title'),
              icon: 'paperclip',
              children: null
            }]
          }, {
            link: null,
            caption: i18n.t('forms.application.sitemap.логистика.номенклатура.caption'),
            title: i18n.t('forms.application.sitemap.логистика.номенклатура.title'),
            children: [{
              link: 'i-i-s-vsempoka-товары-l',
              caption: i18n.t('forms.application.sitemap.логистика.номенклатура.i-i-s-vsempoka-товары-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.номенклатура.i-i-s-vsempoka-товары-l.title'),
              icon: 'chart line',
              children: null
            }]
          }, {
            link: null,
            caption: i18n.t('forms.application.sitemap.логистика.документы.caption'),
            title: i18n.t('forms.application.sitemap.логистика.документы.title'),
            children: [{
              link: 'i-i-s-vsempoka-формир-рез-пос-l',
              caption: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-формир-рез-пос-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-формир-рез-пос-l.title'),
              icon: 'folder open',
              children: null
            }, {
              link: 'i-i-s-vsempoka-докум-постав-l',
              caption: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-докум-постав-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-докум-постав-l.title'),
              icon: 'suitcase',
              children: null
            }, {
              link: 'i-i-s-vsempoka-формир-док-распр-l',
              caption: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-формир-док-распр-l.caption'),
              title: i18n.t('forms.application.sitemap.логистика.документы.i-i-s-vsempoka-формир-док-распр-l.title'),
              icon: 'calendar',
              children: null
            }]
          }]
        }
      ]
    };
  }),
})