import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  единицыИзмер: DS.attr('i-i-s-vsempoka-ед-измер'),
  масса: DS.attr('number'),
  наимТовара: DS.attr('string'),
  производитель: DS.attr('string'),
  цены: DS.attr('number')
});

export let ValidationRules = {
  единицыИзмер: {
    descriptionKey: 'models.i-i-s-vsempoka-товары.validations.единицыИзмер.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  масса: {
    descriptionKey: 'models.i-i-s-vsempoka-товары.validations.масса.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  наимТовара: {
    descriptionKey: 'models.i-i-s-vsempoka-товары.validations.наимТовара.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  производитель: {
    descriptionKey: 'models.i-i-s-vsempoka-товары.validations.производитель.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  цены: {
    descriptionKey: 'models.i-i-s-vsempoka-товары.validations.цены.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ТоварыE', 'i-i-s-vsempoka-товары', {
    наимТовара: attr('Наименование товара', { index: 0 }),
    производитель: attr('Производитель', { index: 1 }),
    единицыИзмер: attr('Единицы измерения', { index: 2 }),
    цены: attr('Цены', { index: 3 }),
    масса: attr('Масса', { index: 4 })
  });

  modelClass.defineProjection('ТоварыL', 'i-i-s-vsempoka-товары', {
    наимТовара: attr('Наименование товара', { index: 0 }),
    производитель: attr('Производитель', { index: 1 }),
    единицыИзмер: attr('Единицы измерения', { index: 2 }),
    цены: attr('Цены', { index: 3 }),
    масса: attr('Масса', { index: 4 })
  });
};
