# Conversão de Arquivos Texto para Binário e Vice-Versa

Este projeto consiste em um programa em C# que converte arquivos de texto em arquivos binários compactados e, em seguida, pode converter arquivos binários de volta para texto. O processo de conversão binária envolve a compactação dos dados usando GZip.

## Funcionalidades

- **Converter de Texto para Binário**: Converte arquivos `.txt` em arquivos `.bin`, compactando o conteúdo dos arquivos de texto usando GZip.
- **Converter de Binário para Texto**: Converte arquivos `.bin` de volta para arquivos `.txt`, descompactando o conteúdo dos arquivos binários usando GZip.

## Requisitos

- .NET Core 3.1 ou superior
- Ambiente de desenvolvimento C# (como Visual Studio ou Visual Studio Code)

## Estrutura dos Diretórios

- `txt/`: Diretório onde os arquivos `.txt` de origem devem ser armazenados.
- `binary/`: Diretório onde os arquivos `.bin` convertidos serão armazenados.
- `txt/`: Diretório onde os arquivos `.txt` resultantes da conversão de binário para texto serão armazenados.

## Como Usar

1. **Preparar Diretórios**
   - Crie dois diretórios no mesmo local onde o executável será executado: `txt` e `binary`.

2. **Colocar Arquivos de Texto**
   - Coloque os arquivos `.txt` que você deseja converter no diretório `txt`.

3. **Executar o Programa**
   - Compile e execute o programa.
   - Você verá um menu com duas opções:
     - `1 - Converter de texto para binário`
     - `2 - Converter de binário para texto`

4. **Escolher Operação**
   - Selecione a operação desejada digitando `1` ou `2` e pressione Enter.

5. **Verificar Resultados**
   - Os arquivos convertidos serão armazenados nos diretórios apropriados (`binary` para arquivos binários e `txt` para arquivos de texto).

## Exemplo de Saída

Ao executar o programa e selecionar a conversão, você verá mensagens de sucesso para cada arquivo convertido:

## Notas

- Certifique-se de que os diretórios `txt` e `binary` existam antes de executar o programa.
- O programa adiciona uma pausa de 1,5 segundos entre as conversões para evitar sobrecarga no sistema.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
