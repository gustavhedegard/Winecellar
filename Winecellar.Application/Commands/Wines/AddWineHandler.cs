﻿using MediatR;

namespace Winecellar.Application.Commands.Wines
{
    public class AddWineHandler : IRequestHandler<AddWineCommand>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddWineHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(AddWineCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddWine(request.wine);

            return;
        }
    }
}
