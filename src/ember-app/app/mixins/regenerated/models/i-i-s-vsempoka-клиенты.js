import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  адресПоствки: DS.attr('string'),
  заказчик: DS.attr('string'),
  расчетСчет: DS.attr('number'),
  телефон: DS.attr('number')
});

export let ValidationRules = {
  адресПоствки: {
    descriptionKey: 'models.i-i-s-vsempoka-клиенты.validations.адресПоствки.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  заказчик: {
    descriptionKey: 'models.i-i-s-vsempoka-клиенты.validations.заказчик.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  расчетСчет: {
    descriptionKey: 'models.i-i-s-vsempoka-клиенты.validations.расчетСчет.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  телефон: {
    descriptionKey: 'models.i-i-s-vsempoka-клиенты.validations.телефон.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('КлиентыE', 'i-i-s-vsempoka-клиенты', {
    заказчик: attr('Заказчик', { index: 0 }),
    телефон: attr('Телефон', { index: 1 }),
    адресПоствки: attr('Адрес поставки', { index: 2 }),
    расчетСчет: attr('Расчетный счет', { index: 3 })
  });

  modelClass.defineProjection('КлиентыL', 'i-i-s-vsempoka-клиенты', {
    заказчик: attr('Заказчик', { index: 0 }),
    телефон: attr('Телефон', { index: 1 }),
    адресПоствки: attr('Адрес поствки', { index: 2 }),
    расчетСчет: attr('Расчетный счет', { index: 3 })
  });
};
