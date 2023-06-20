# SQLite �� Entity Framework ������

## Nuget �ŃC���X�g�[�� 

- Microsoft.EntityFrameworkCore.Sqlite.Core
- Microsoft.EntityFrameworkCore.Tools

### �⑫

- �o�[�W������ `5.0.17`
  - �o�[�W����6�ȍ~�� ,Net �̃o�[�W����������Ȃ�����
    - ���J�����́@.Net5

## �}�C�O���[�V���������s�����Ƃ�����G���[����

```
You need to call SQLitePCL.raw.SetProvider().  If you are using a bundle package, this is done by calling SQLitePCL.Batteries.Init().
```

### �Ή��H

- Microsoft.Data.Sqlite ���C���X�g�[������
- https://github.com/dotnet/efcore/issues/24493#issuecomment-1228643696

## Nuget �p�b�P�[�W�}�l�[�W���[�̃p�b�P�[�W�}�l�[�W���[�R���\�[���ŃR�}���h�����s����

- �c�[�� -> Nuget �p�b�P�[�W�}�l�[�W���[ -> �p�b�P�[�W�}�l�[�W���[�R���\�[��
  - Add-Migration InitialCreate
    - �쐬�����N���X����f�[�^�x�[�X�t�@�C�����쐬����
  - Update-Database
    - �R�[�h�̕ύX�𔽉f����H

## �Q�l

- �yC#�zEntity Framework Core���g����SQLite�𑀍삷��
  - https://hirahira.blog/efcore-sqlite/