using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.FormUtilitySamples.Tests
{
    public static class Consts
    {
        public static string ERR_SYSTEM = "システムエラーが発生しました。管理者に連絡してください。";
        public static string ERR_DB = "データベースエラーが発生しました。管理者に連絡してください。";
        public static string ERR_DB_OPEN = "データベース接続を開く際にエラーが発生しました。";
        public static string ERR_DB_BEGIN_TRANSACTION = "トランザクションを開始する際にエラーが発生しました。";
        public static string ERR_DB_COMMIT = "トランザクションをコミットする際にエラーが発生しました。";
        public static string ERR_DB_ROLLBACK = "トランザクションをロールバックする際にエラーが発生しました。";
        public static string ERR_DB_CLOSE = "データベース接続を閉じる際にエラーが発生しました。";
        public static string ERR_DB_SQL = "SQLエラーが発生しました。";
        public static string ERR_NETWORK = "ネットワークエラーが発生しました。管理者に連絡してください。";
    }

    public static class MyMessageConstant
    {
        public static readonly MessageConstant ERR_SYSTEM =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_SYSTEM);

        public static readonly MessageConstant ERR_DB =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB);

        public static readonly MessageConstant ERR_DB_OPEN =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_OPEN);

        public static readonly MessageConstant ERR_DB_BEGIN_TRANSACTION =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_BEGIN_TRANSACTION);

        public static readonly MessageConstant ERR_DB_COMMIT =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_COMMIT);

        public static readonly MessageConstant ERR_DB_ROLLBACK =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_ROLLBACK);

        public static readonly MessageConstant ERR_DB_CLOSE =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_CLOSE);

        public static readonly MessageConstant ERR_DB_SQL =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_DB_SQL);

        public static readonly MessageConstant ERR_NETWORK =
            new MessageConstant(MessageBoxIcon.Error, MessageBoxButtons.OK, () => Consts.ERR_NETWORK);
    }

    [TestClass]
    public class MessageConstantTest
    {
        [TestMethod]
        public void TestERR_SYSTEM()
        {
            // Arrange
            var msg = MyMessageConstant.ERR_SYSTEM;
            // Act
            // Assert
            Assert.AreEqual("システムエラーが発生しました。管理者に連絡してください。", msg.MbMessage);
        }
    }
}
