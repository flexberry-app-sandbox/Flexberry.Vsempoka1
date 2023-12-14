import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  количество: DS.attr('number'),
  товары: DS.belongsTo('i-i-s-vsempoka-товары', { inverse: null, async: false }),
  докумПостав: DS.belongsTo('i-i-s-vsempoka-докум-постав', { inverse: 'инфорОЗаказе', async: false })
});

export let ValidationRules = {
  количество: {
    descriptionKey: 'models.i-i-s-vsempoka-инфор-о-заказе.validations.количество.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  товары: {
    descriptionKey: 'models.i-i-s-vsempoka-инфор-о-заказе.validations.товары.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  докумПостав: {
    descriptionKey: 'models.i-i-s-vsempoka-инфор-о-заказе.validations.докумПостав.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ИнфорОЗаказеE', 'i-i-s-vsempoka-инфор-о-заказе', {
    товары: belongsTo('i-i-s-vsempoka-товары', 'Наименование товара', {
      наимТовара: attr('Наименование товара', { index: 1, hidden: true }),
      единицыИзмер: attr('Единицы измерения', { index: 3 }),
      масса: attr('Масса', { index: 4 }),
      цены: attr('Цена', { index: 5 })
    }, { index: 0, displayMemberPath: 'наимТовара' }),
    количество: attr('Количество', { index: 2 })
  });
};
