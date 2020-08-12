using RoR2;
using System;
using UnityEngine;

namespace UmbraRoR
{
    internal class DrawMenu
    {
        public static Vector2 itemSpawnerScrollPosition = Vector2.zero;
        public static Vector2 equipmentSpawnerScrollPosition = Vector2.zero;
        public static Vector2 buffMenuScrollPosition = Vector2.zero;
        public static Vector2 characterScrollPosition = Vector2.zero;
        public static Vector2 spawnScrollPosition = Vector2.zero;

        public static void DrawNotCollectedMenu(GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle)
        {
            if (Updates.updateAvailable)
            {
                DrawButton(2, "main", "<color=yellow>�ȴ�������Ϸ.</color>", buttonStyle, justText: true);
                DrawButton(3, "main", "<color=#11ccee>�����𣬽���Ϸ.\n �ٿ�������.</color>", buttonStyle, justText: true);
                DrawButton(4, "main", "<color=#11ccee>����֮��������.\nAcher0ns/Umbra-Mod-Menu</color>", buttonStyle, justText: true);
            }
            else if (Updates.upToDate || Updates.devBuild)
            {
                DrawButton(2, "main", "<color=yellow>�ȴ�������Ϸ.</color>", buttonStyle, justText: true);
                DrawButton(3, "main", "<color=#11ccee>�����𣬽���Ϸ.\n �ٿ�������.</color>", buttonStyle, justText: true);
                DrawButton(4, "main", "<color=#11ccee>����֮��������.</color>", buttonStyle, justText: true);
            }
        }

        public static void DrawMainMenu(float x, float y, float widthSize, float mulY, GUIStyle BGstyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle ButtonStyle)
        {
            if (Main._isPlayerMod)
            {
                DrawButton(1, "main", "��� : ��", OnStyle);
            }
            else
            {
                DrawButton(1, "main", "��� : ��", OffStyle);
            }

            if (Main._isMovementOpen)
            {
                DrawButton(2, "main", "�ƶ� : ��", OnStyle);
            }
            else
            {
                DrawButton(2, "main", "�ƶ� : ��", OffStyle);
            }

            if (Main._isItemManagerOpen)
            {
                DrawButton(3, "main", "��Ʒ : ON", OnStyle);
            }
            else
            {
                DrawButton(3, "main", "��Ʒ : ��", OffStyle);
            }

            if (Main._isSpawnMenuOpen)
            {
                DrawButton(4, "main", "���� : ��", OnStyle);
            }
            else
            {
                DrawButton(4, "main", "���� : ��", OffStyle);
            }

            if (Main._isTeleMenuOpen)
            {
                DrawButton(5, "main", "���� : ��", OnStyle);
            }
            else
            {
                DrawButton(5, "main", "���� : ��", OffStyle);
            }

            if (Main._isESPMenuOpen)
            {
                DrawButton(6, "main", "��Ⱦ : ��", OnStyle);
            }
            else
            {
                DrawButton(6, "main", "��Ⱦ : ��", OffStyle);
            }

            if (Main._isLobbyMenuOpen)
            {
                DrawButton(7, "main", "���� : ��", OnStyle);
            }
            else
            {
                DrawButton(7, "main", "���� : ��", OffStyle);
            }

            if (Main.unloadConfirm)
            {
                DrawButton(8, "main", "ȷ�� ?", ButtonStyle);
            }
            else
            {
                DrawButton(8, "main", "�ر�Poke", ButtonStyle);
            }
        }

        public static void DrawPlayerModMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "���   �˵�", LabelStyle);

            DrawButton(1, "playermod", $"��ȡ   $ : {PlayerMod.moneyToGive}", buttonStyle, isMultButton: true);
            DrawButton(2, "playermod", $"��ȡ   ����Ӳ�� : {PlayerMod.coinsToGive}", buttonStyle, isMultButton: true);
            DrawButton(3, "playermod", $"��ȡ   ���� : {PlayerMod.xpToGive}", buttonStyle, isMultButton: true);

            if (Main._isEditStatsOpen)
            {
                DrawButton(4, "playermod", "����   �˵� : ON", OnStyle);
            }
            else
            {
                DrawButton(4, "playermod", "����   �˵� : OFF", OffStyle);
            }
            if (Main._isChangeCharacterMenuOpen)
            {
                DrawButton(5, "playermod", "�ı��ɫ : ON", OnStyle);
            }
            else
            {
                DrawButton(5, "playermod", "�ı��ɫ : OFF", OffStyle);
            }
            if (Main._isBuffMenuOpen)
            {
                DrawButton(6, "playermod", "��ȡ   B U F F   �˵� : ��", OnStyle);
            }
            else
            {
                DrawButton(6, "playermod", "��ȡ   B U F F   �˵� : ��", OffStyle);
            }

            DrawButton(7, "playermod", "������� B U F F", buttonStyle);

            if (Main.aimBot)
            {
                DrawButton(8, "playermod", " : ��", OnStyle);
            }
            else
            {
                DrawButton(8, "playermod", " : ��", OffStyle);
            }
            if (Main.godToggle)
            {
                DrawButton(9, "playermod", "�޵� : ��", OnStyle);
            }
            else
            {
                DrawButton(9, "playermod", "�޵� : ��", OffStyle);
            }
            if (Main.skillToggle)
            {
                DrawButton(10, "playermod", "������CD : ��", OnStyle);
            }
            else
            {
                DrawButton(10, "playermod", "������CD : ��", OffStyle);
            }
            DrawButton(11, "playermod", "ȫ������", buttonStyle);
        }

        public static void DrawMovementMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "�ƶ�   �˵�", LabelStyle);

            if (Main.alwaysSprint)
            {
                DrawButton(1, "movement", "���� : ��", OnStyle);
            }
            else
            {
                DrawButton(1, "movement", "���� : ��", OffStyle);
            }

            if (Main.FlightToggle)
            {
                DrawButton(2, "movement", "������ ү�ɹ�ȥ : ��", OnStyle);
            }
            else
            {
                DrawButton(2, "movement", "������ ү�ɹ�ȥ : ��", OffStyle);
            }

            if (Main.jumpPackToggle)
            {
                DrawButton(3, "movement", "������ : ��", OnStyle);
            }
            else
            {
                DrawButton(3, "movement", "������ : ��", OffStyle);
            }
        }

        public static void DrawItemManagementMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "��Ʒ   �˵�", LabelStyle);

            DrawButton(1, "itemmanager", $"��ȡ   ������Ʒ : {ItemManager.allItemsQuantity}", buttonStyle, isMultButton: true);
            DrawButton(2, "itemmanager", $"���   ��Ʒ : {ItemManager.itemsToRoll}", buttonStyle, isMultButton: true);

            if (Main._isItemSpawnMenuOpen)
            {
                DrawButton(3, "itemmanager", "������Ʒ   �˵� : ��", OnStyle);
            }
            else
            {
                DrawButton(3, "itemmanager", "������Ʒ   �˵� : ��", OffStyle);
            }
            if (Main._isEquipmentSpawnMenuOpen)
            {
                DrawButton(4, "itemmanager", "װ��   ����   �˵� : ��", OnStyle);
            }
            else
            {
                DrawButton(4, "itemmanager", "װ��   ����   �˵� : ��", OffStyle);
            }
            if (ItemManager.isDropItemForAll)
            {
                DrawButton(5, "itemmanager", "����   ��Ʒ / װ�� : ��", OnStyle);
            }
            else
            {
                DrawButton(5, "itemmanager", "����   ��Ʒ / װ�� : ��", OffStyle);
            }
            if (ItemManager.isDropItemFromInventory)
            {
                DrawButton(6, "itemmanager", "������   ��� : ��", OnStyle);
            }
            else
            {
                DrawButton(6, "itemmanager", "������   ��� : ��", OffStyle);
            }
            if (Main.noEquipmentCooldown)
            {
                DrawButton(7, "itemmanager", "��װ��CD : ��", OnStyle);
            }
            else
            {
                DrawButton(7, "itemmanager", "��װ��CD : ��", OffStyle);
            }

            DrawButton(8, "itemmanager", "��   ���", buttonStyle);
            DrawButton(9, "itemmanager", "����   ���", buttonStyle);
        }

        public static void DrawSpawnMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "����   �˵�", LabelStyle);

            DrawButton(1, "spawn", $"��С���� : {Spawn.minDistance}", buttonStyle, isMultButton: true);
            DrawButton(2, "spawn", $"������ : {Spawn.maxDistance}", buttonStyle, isMultButton: true);
            DrawButton(3, "spawn", $"��Ӫ : {Spawn.team[Spawn.teamIndex]}", buttonStyle, isMultButton: true);

            if (Main._isSpawnListMenuOpen)
            {
                DrawButton(4, "spawn", "����   �б� : ��", OnStyle);
            }
            else
            {
                DrawButton(4, "spawn", "����   �б� : ��", OffStyle);
            }

            DrawButton(5, "spawn", "ɱ�����е���", buttonStyle);
            DrawButton(6, "spawn", "ɱ��������Ʒ", buttonStyle);
        }

        public static void DrawTeleMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "����   �˵�", LabelStyle);

            DrawButton(1, "tele", "����", buttonStyle);
            DrawButton(2, "tele", "����   ����", buttonStyle);
            DrawButton(3, "tele", $"��� : {TeleporterInteraction.instance.shrineBonusStacks}", buttonStyle);
            DrawButton(4, "tele", "����   ȫ��  ����", buttonStyle);
            DrawButton(5, "tele", "����   ��ɫ   ����", buttonStyle);
            DrawButton(6, "tele", "����   ����ɫ   ����", buttonStyle);
            DrawButton(7, "tele", "����   ��ɫ   ����", buttonStyle);
        }

        public static void DrawRenderMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "��Ⱦ   �˵�", LabelStyle);

            if (Main.renderActiveMods)
            {
                DrawButton(1, "͸��", "��ʾ : ��", OnStyle);
            }
            else
            {
                DrawButton(1, "͸��", "��ʾ : ��", OffStyle);
            }

            if (Main.renderInteractables)
            {
                DrawButton(2, "͸��", "��Ʒ : ��", OnStyle);
            }
            else
            {
                DrawButton(2, "͸��", "��Ʒ : ��", OffStyle);
            }

            if (Main.renderMobs)
            {
                DrawButton(3, "͸��", "����  : O N\n<color=red>ע��: Ҳ��� ��֡����Ϸ���� </color>", OnStyle);
            }
            else
            {
                DrawButton(3, "͸��", "���� : O F F\n<color=red>ע��: Ҳ��� ��֡����Ϸ���� </color>", OffStyle);
            }
        }

        public static void DrawLobbyMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "����   �˵�", LabelStyle);

            if (Main._CharacterCollected)
            {
                Lobby.GetPlayers(Main.Players); //update this asap
                int buttonPlacement = 1;
                for (int i = 0; i < Main.Players.Length; i++)
                {
                    try
                    {
                        if (Main.Players[i] != null)
                        {
                            DrawButton(buttonPlacement, "lobby", $"�߳�  <color=yellow>{Main.Players[i]}</color>", buttonStyle);
                            buttonPlacement++;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        Debug.LogWarning("UmbraRoR: û��ѡ�����");
                    }
                }
            }
        }

        public static void CharacterWindowMethod(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 85f), "��ɫ   �˵�", LabelStyle);

            characterScrollPosition = GUI.BeginScrollView(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), characterScrollPosition, new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), false, true);
            PlayerMod.ChangeCharacter(buttonStyle, "character");
            GUI.EndScrollView();
        }

        public static void DrawBuffMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle, GUIStyle offStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 20, 50f + 45 * 15), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "B U F F S   �б�", LabelStyle);

            buffMenuScrollPosition = GUI.BeginScrollView(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), buffMenuScrollPosition, new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), false, true);
            PlayerMod.GiveBuff(buttonStyle, "giveBuff");
            GUI.EndScrollView();
        }

        public static void DrawStatsModMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle OnStyle, GUIStyle OffStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "����   �˵�", LabelStyle);

            if (Main.damageToggle)
            {
                DrawButton(1, "statsmod", $"�˺� ( �� ) : {PlayerMod.damagePerLvl}", OnStyle, true);
            }
            else
            {
                DrawButton(1, "statsmod", $"�˺� ( �� ) : {PlayerMod.damagePerLvl}", OffStyle, true);
            }
            if (Main.critToggle)
            {
                DrawButton(2, "statsmod", $"���� ( �� ) : {PlayerMod.CritPerLvl}", OnStyle, true);
            }
            else
            {
                DrawButton(2, "statsmod", $"���� ( �� ) : {PlayerMod.CritPerLvl}", OffStyle, true);
            }
            if (Main.attackSpeedToggle)
            {
                DrawButton(3, "statsmod", $"�����ٶ� ( �� ) : {PlayerMod.attackSpeed}", OnStyle, true);
            }
            else
            {
                DrawButton(3, "statsmod", $"�����ٶ� ( �� ) : {PlayerMod.attackSpeed}", OffStyle, true);
            }
            if (Main.armorToggle)
            {
                DrawButton(4, "statsmod", $"���� ( �� ) : {PlayerMod.armor}", OnStyle, true);
            }
            else
            {
                DrawButton(4, "statsmod", $"���� ( �� ) : {PlayerMod.armor}", OffStyle, true);
            }
            if (Main.moveSpeedToggle)
            {
                DrawButton(5, "statsmod", $"�ƶ��ٶ� ( �� ) : {PlayerMod.movespeed}", OnStyle, true);
            }
            else
            {
                DrawButton(5, "statsmod", $"�ƶ��ٶ� ( �� ) : {PlayerMod.movespeed}", OffStyle, true);
            }
            if (Main._isStatMenuOpen)
            {
                DrawButton(6, "statsmod", "��ʾ   ���� : ��", OnStyle);
            }
            else
            {
                DrawButton(6, "statsmod", "��ʾ   ���� : ��", OffStyle);
            }
        }

        public static void DrawItemMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 20, 50f + 45 * 15), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "��Ʒ   �б�", LabelStyle);

            itemSpawnerScrollPosition = GUI.BeginScrollView(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), itemSpawnerScrollPosition, new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), false, true);
            int buttonPlacement = 1;
            foreach (var itemIndex in Main.items)
            {
                string itemName = itemIndex.ToString();
                DrawButton(buttonPlacement, "itemSpawner", itemName, buttonStyle);
                buttonPlacement++;
            }
            GUI.EndScrollView();
        }

        public static void DrawEquipmentMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle, GUIStyle offStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 20, 50f + 45 * 15), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "װ��   �б�", LabelStyle);

            equipmentSpawnerScrollPosition = GUI.BeginScrollView(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), equipmentSpawnerScrollPosition, new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), false, true);
            int buttonPlacement = 1;
            foreach (var equipmentIndex in Main.equipment)
            {
                string equipmentName = equipmentIndex.ToString();
                DrawButton(buttonPlacement, "equipmentSpawner", equipmentName, buttonStyle);
                buttonPlacement++;
            }
            GUI.EndScrollView();
        }

        public static void DrawSpawnMobMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize + 20, 50f + 45 * 15), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 10, 85f), "����   �б�", LabelStyle);

            spawnScrollPosition = GUI.BeginScrollView(new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * 15), spawnScrollPosition, new Rect(x + 0f, y + 0f, widthSize + 10, 50f + 45 * mulY), false, true);
            Spawn.SpawnMob(buttonStyle, "spawnMob");
            GUI.EndScrollView();
        }

        public static void DrawStatsMenu(float x, float y, float widthSize, int mulY, GUIStyle BGstyle, GUIStyle buttonStyle, GUIStyle LabelStyle)
        {
            GUI.Box(new Rect(x + 0f, y + 0f, widthSize, 50f + 45 * mulY), "", BGstyle);
            GUI.Label(new Rect(x + 5f, y + 5f, widthSize + 5, 50f), "����   �˵�", LabelStyle);

            DrawButton(1, "stats", $"�˺� : {Main.LocalPlayerBody.damage}", buttonStyle, justText: true);
            DrawButton(2, "stats", $"���� : {Main.LocalPlayerBody.crit}", buttonStyle, justText: true);
            DrawButton(3, "stats", $"�����ٶ� : {Main.LocalPlayerBody.attackSpeed}", buttonStyle, justText: true);
            DrawButton(4, "stats", $"���� : {Main.LocalPlayerBody.armor}", buttonStyle, justText: true);
            DrawButton(5, "stats", $"K K P : {Main.LocalPlayerBody.regen}", buttonStyle, justText: true);
            DrawButton(6, "stats", $"�ƶ��ٶ� : {Main.LocalPlayerBody.moveSpeed}", buttonStyle, justText: true);
            DrawButton(7, "stats", $"���� : {Main.LocalPlayerBody.maxJumpCount}", buttonStyle, justText: true);
            DrawButton(8, "stats", $"���� : {Main.LocalPlayerBody.experience}", buttonStyle, justText: true);
            DrawButton(9, "stats", $"��ɱ��: {Main.LocalPlayerBody.killCount}", buttonStyle, justText: true);

        }

        // A Wrapper Method For Drawing Buttons
        public static void DrawButton(int position, string id, string text, GUIStyle defaultStyle, bool isMultButton = false, bool justText = false)
        {
            Rect rect;
            Rect menuBg;
            GUIStyle highlighted = Main.HighlightBtnStyle;
            float menuIndex;
            int intraMenuIndex = position - 1;
            int btnY = 5 + 45 * position;
            // Rect for buttons
            // It automatically position buttons based on id and position. There is no need to change it
            switch (id)
            {
                case "main":
                    {
                        menuIndex = 0;
                        menuBg = Main.mainRect;
                        Main.MainMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.mainRect.x + 5, Main.mainRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.mainRect.x + 5, Main.mainRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "playermod":
                    {
                        menuIndex = 1;
                        menuBg = Main.playerModRect;
                        Main.PlayerModMulY = position;
                        Main.PlayerModBtnY = btnY;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.playerModRect.x + 5, Main.playerModRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.playerModRect.x + 5, Main.playerModRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "character":
                    {
                        menuIndex = 1.1f;
                        menuBg = Main.characterRect;
                        Main.CharacterMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.characterRect.x + 5, Main.characterRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.characterRect.x + 5, Main.characterRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "giveBuff":
                    {
                        menuIndex = 1.2f;
                        menuBg = Main.buffMenuRect;
                        Main.buffMenuMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.buffMenuRect.x + 5, Main.buffMenuRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.buffMenuRect.x + 5, Main.buffMenuRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "statsmod":
                    {
                        menuIndex = 1.3f;
                        menuBg = Main.editStatsRect;
                        Main.editStatsMulY = position;
                        Main.editStatsBtnY = btnY;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.editStatsRect.x + 5, Main.editStatsRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.editStatsRect.x + 5, Main.editStatsRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "movement":
                    {
                        menuIndex = 2f;
                        menuBg = Main.movementRect;
                        Main.movementMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.movementRect.x + 5, Main.movementRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.movementRect.x + 5, Main.movementRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "itemmanager":
                    {
                        menuIndex = 3f;
                        menuBg = Main.itemManagerRect;
                        Main.ItemManagerMulY = position;
                        Main.ItemManagerBtnY = btnY;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.itemManagerRect.x + 5, Main.itemManagerRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.itemManagerRect.x + 5, Main.itemManagerRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "itemSpawner":
                    {
                        menuIndex = 3.1f;
                        menuBg = Main.itemSpawnerRect;
                        Main.itemSpawnerMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.itemSpawnerRect.x + 5, Main.itemSpawnerRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.itemSpawnerRect.x + 5, Main.itemSpawnerRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "equipmentSpawner":
                    {
                        menuIndex = 3.2f;
                        menuBg = Main.equipmentSpawnerRect;
                        Main.equipmentSpawnerMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.equipmentSpawnerRect.x + 5, Main.equipmentSpawnerRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.equipmentSpawnerRect.x + 5, Main.equipmentSpawnerRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "spawn":
                    {
                        menuIndex = 4f;
                        menuBg = Main.spawnRect;
                        Main.spawnMulY = position;
                        Main.spawnBtnY = btnY;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.spawnRect.x + 5, Main.spawnRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.spawnRect.x + 5, Main.spawnRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "spawnMob":
                    {
                        menuIndex = 4.1f;
                        menuBg = Main.spawnListRect;
                        Main.spawnListMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.spawnListRect.x + 5, Main.spawnListRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.spawnListRect.x + 5, Main.spawnListRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "tele":
                    {
                        menuIndex = 5f;
                        menuBg = Main.teleRect;
                        Main.TeleMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.teleRect.x + 5, Main.teleRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.teleRect.x + 5, Main.teleRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "͸��":
                    {
                        menuIndex = 6f;
                        menuBg = Main.ESPRect;
                        Main.ESPMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.ESPRect.x + 5, Main.ESPRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.ESPRect.x + 5, Main.ESPRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "lobby":
                    {
                        menuIndex = 7f;
                        menuBg = Main.lobbyRect;
                        Main.LobbyMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.lobbyRect.x + 5, Main.lobbyRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.lobbyRect.x + 5, Main.lobbyRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                case "stats":
                    {
                        menuIndex = 99f;
                        menuBg = Main.statRect;
                        Main.StatMulY = position;
                        if (isMultButton)
                        {
                            rect = new Rect(Main.statRect.x + 5, Main.statRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        }
                        else
                        {
                            rect = new Rect(Main.statRect.x + 5, Main.statRect.y + 5 + 45 * position, Main.widthSize, 40);
                        }
                        break;
                    }

                default:
                    {
                        menuBg = Main.mainRect;
                        menuIndex = 0;
                        rect = new Rect(Main.mainRect.x + 5, Main.mainRect.y + 5 + 45 * position, Main.widthSize - 90, 40);
                        break;
                    }
            }

            // Creates the button and its OnClick action based on PressBtn() input
            // Dont want text to be highlighted so remove that from the Button() call
            if (justText && isMultButton)
            {
                throw new Exception($"justText and isMultButton cannot both be true. Thrown in \"{text}\" button.");
            }
            else if (justText)
            {
                GUI.Button(rect, text, defaultStyle);
            }
            else if (isMultButton)
            {
                if (GUI.Button(rect, text, Navigation.HighlighedCheck(defaultStyle, highlighted, menuIndex, position)))
                {
                    Navigation.PressBtn(menuIndex, intraMenuIndex);
                }
                if (GUI.Button(new Rect(menuBg.x + Main.widthSize - 80, menuBg.y + btnY, 40, 40), "-", Main.OffStyle))
                {
                    Navigation.DecreaseValue(menuIndex, intraMenuIndex);
                }
                if (GUI.Button(new Rect(menuBg.x + Main.widthSize - 35, menuBg.y + btnY, 40, 40), "+", Main.OffStyle))
                {
                    if (Spawn.minDistance < Spawn.maxDistance)
                    {
                        Navigation.IncreaseValue(menuIndex, intraMenuIndex);
                    }
                }
            }
            else
            {
                if (GUI.Button(rect, text, Navigation.HighlighedCheck(defaultStyle, highlighted, menuIndex, position)))
                {
                    Navigation.PressBtn(menuIndex, intraMenuIndex);
                }
            }
        }
    }
}
