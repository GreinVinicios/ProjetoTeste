import { ProjetoTesteTemplatePage } from './app.po';

describe('ProjetoTeste App', function() {
  let page: ProjetoTesteTemplatePage;

  beforeEach(() => {
    page = new ProjetoTesteTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
