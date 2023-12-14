import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-vsempoka-формир-рез-пос', 'Unit | Serializer | i-i-s-vsempoka-формир-рез-пос', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-vsempoka-формир-рез-пос',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-vsempoka-ед-измер',
    'transform:i-i-s-vsempoka-состоян-заказа',
    'transform:i-i-s-vsempoka-удовл-клиента',

    'model:i-i-s-vsempoka-докум-постав',
    'model:i-i-s-vsempoka-инфор-о-заказе',
    'model:i-i-s-vsempoka-клиенты',
    'model:i-i-s-vsempoka-организация',
    'model:i-i-s-vsempoka-пункт-погрузки',
    'model:i-i-s-vsempoka-список-барж',
    'model:i-i-s-vsempoka-список-контей',
    'model:i-i-s-vsempoka-товары',
    'model:i-i-s-vsempoka-формир-док-распр',
    'model:i-i-s-vsempoka-формир-рез-пос',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
