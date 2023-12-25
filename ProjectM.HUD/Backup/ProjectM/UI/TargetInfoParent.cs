// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TargetInfoParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TargetInfoParent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NameInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_Profession;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkullIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfrssionNameList;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodColor_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodColor_VBlood;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTarget_Internal_Void_Data_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProfessionName_Private_LocalizationKey_ServantType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276042, RefRangeEnd = 1276043, XrefRangeStart = 1275996, XrefRangeEnd = 1276042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTarget(TargetInfoParent.Data target, GameDataSystem gameDataSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) target));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetInfoParent.NativeMethodInfoPtr_UpdateTarget_Internal_Void_Data_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276059, RefRangeEnd = 1276060, XrefRangeStart = 1276043, XrefRangeEnd = 1276059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationKey GetProfessionName(ServantType servantType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &servantType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParent.NativeMethodInfoPtr_GetProfessionName_Private_LocalizationKey_ServantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetInfoParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetInfoParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TargetInfoParent()
    {
      Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TargetInfoParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr);
      TargetInfoParent.NativeFieldInfoPtr_NameInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (NameInfo));
      TargetInfoParent.NativeFieldInfoPtr_HealthInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (HealthInfo));
      TargetInfoParent.NativeFieldInfoPtr_LevelInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (LevelInfo));
      TargetInfoParent.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (Motion2DInOut));
      TargetInfoParent.NativeFieldInfoPtr_Text_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (Text_BloodType));
      TargetInfoParent.NativeFieldInfoPtr_Text_Profession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (Text_Profession));
      TargetInfoParent.NativeFieldInfoPtr_SkullIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (SkullIcon));
      TargetInfoParent.NativeFieldInfoPtr_ProfrssionNameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (ProfrssionNameList));
      TargetInfoParent.NativeFieldInfoPtr_BloodType_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (BloodType_Normal));
      TargetInfoParent.NativeFieldInfoPtr_BloodType_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (BloodType_VBlood));
      TargetInfoParent.NativeFieldInfoPtr_BloodColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (BloodColor_Normal));
      TargetInfoParent.NativeFieldInfoPtr_BloodColor_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (BloodColor_VBlood));
      TargetInfoParent.NativeMethodInfoPtr_UpdateTarget_Internal_Void_Data_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, 100668524);
      TargetInfoParent.NativeMethodInfoPtr_GetProfessionName_Private_LocalizationKey_ServantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, 100668525);
      TargetInfoParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, 100668526);
    }

    public TargetInfoParent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterHUD_NameComponent NameInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_NameInfo));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_NameComponent) null : new CharacterHUD_NameComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_NameInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_HealthComponent HealthInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_HealthInfo));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_HealthComponent) null : new CharacterHUD_HealthComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_HealthInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_LevelComponent LevelInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_LevelInfo));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_LevelComponent) null : new CharacterHUD_LevelComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_LevelInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Text_BloodType));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Text_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_Profession
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Text_Profession));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_Text_Profession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SkullIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_SkullIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_SkullIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TargetInfoParent.ProfrssionNameMapper> ProfrssionNameList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_ProfrssionNameList));
        return pointer == System.IntPtr.Zero ? (List<TargetInfoParent.ProfrssionNameMapper>) null : new List<TargetInfoParent.ProfrssionNameMapper>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_ProfrssionNameList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey BloodType_Normal
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodType_Normal));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodType_Normal)) = value;
      }
    }

    public unsafe LocalizationKey BloodType_VBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodType_VBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodType_VBlood)) = value;
      }
    }

    public unsafe Color BloodColor_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodColor_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodColor_Normal)) = value;
      }
    }

    public unsafe Color BloodColor_VBlood
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodColor_VBlood));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.NativeFieldInfoPtr_BloodColor_VBlood)) = value;
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct ProfrssionNameMapper
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProfessionName;
      [FieldOffset(0)]
      public ServantType ServantType;
      [FieldOffset(4)]
      public LocalizationKey ProfessionName;

      static ProfrssionNameMapper()
      {
        Il2CppClassPointerStore<TargetInfoParent.ProfrssionNameMapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (ProfrssionNameMapper));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParent.ProfrssionNameMapper>.NativeClassPtr);
        TargetInfoParent.ProfrssionNameMapper.NativeFieldInfoPtr_ServantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.ProfrssionNameMapper>.NativeClassPtr, nameof (ServantType));
        TargetInfoParent.ProfrssionNameMapper.NativeFieldInfoPtr_ProfessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.ProfrssionNameMapper>.NativeClassPtr, nameof (ProfessionName));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParent.ProfrssionNameMapper>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Exists;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Health;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecentDamageTakenFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReservedColorId;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsVampireHunter;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsElite;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsVBlood;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;

      static Data()
      {
        Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr);
        TargetInfoParent.Data.NativeFieldInfoPtr_Exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (Exists));
        TargetInfoParent.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (Name));
        TargetInfoParent.Data.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (Health));
        TargetInfoParent.Data.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (MaxHealth));
        TargetInfoParent.Data.NativeFieldInfoPtr_HealthFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (HealthFill));
        TargetInfoParent.Data.NativeFieldInfoPtr_RecentDamageTakenFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (RecentDamageTakenFill));
        TargetInfoParent.Data.NativeFieldInfoPtr_AbsorbFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (AbsorbFill));
        TargetInfoParent.Data.NativeFieldInfoPtr_RecoveryFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (RecoveryFill));
        TargetInfoParent.Data.NativeFieldInfoPtr_LocalLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (LocalLevel));
        TargetInfoParent.Data.NativeFieldInfoPtr_EntityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (EntityLevel));
        TargetInfoParent.Data.NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (LocalizedName));
        TargetInfoParent.Data.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (TeamType));
        TargetInfoParent.Data.NativeFieldInfoPtr_ReservedColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (ReservedColorId));
        TargetInfoParent.Data.NativeFieldInfoPtr_IsVampireHunter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (IsVampireHunter));
        TargetInfoParent.Data.NativeFieldInfoPtr_IsElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (IsElite));
        TargetInfoParent.Data.NativeFieldInfoPtr_IsVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (IsVBlood));
        TargetInfoParent.Data.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (BloodQuality));
        TargetInfoParent.Data.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (BloodType));
        TargetInfoParent.Data.NativeFieldInfoPtr_ServantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (ServantType));
        TargetInfoParent.Data.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, nameof (PrefabType));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParent.Data>.NativeClassPtr, data));
      }

      public unsafe bool Exists
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Exists));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Exists)) = value;
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe float Health
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Health));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_Health)) = value;
        }
      }

      public unsafe float MaxHealth
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_MaxHealth));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_MaxHealth)) = value;
        }
      }

      public unsafe float HealthFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_HealthFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_HealthFill)) = value;
        }
      }

      public unsafe float RecentDamageTakenFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_RecentDamageTakenFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_RecentDamageTakenFill)) = value;
        }
      }

      public unsafe float AbsorbFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_AbsorbFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_AbsorbFill)) = value;
        }
      }

      public unsafe float RecoveryFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_RecoveryFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_RecoveryFill)) = value;
        }
      }

      public unsafe Nullable_Unboxed<float> LocalLevel
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_LocalLevel));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_LocalLevel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<float> EntityLevel
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_EntityLevel));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_EntityLevel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe AssetGuid LocalizedName
      {
        get
        {
          return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_LocalizedName));
        }
        [param: In] set
        {
          *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_LocalizedName)) = value;
        }
      }

      public unsafe CharacterHUDSettings.TeamType TeamType
      {
        get
        {
          return *(CharacterHUDSettings.TeamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_TeamType));
        }
        [param: In] set
        {
          *(CharacterHUDSettings.TeamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_TeamType)) = value;
        }
      }

      public unsafe int ReservedColorId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_ReservedColorId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_ReservedColorId)) = value;
        }
      }

      public unsafe bool IsVampireHunter
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsVampireHunter));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsVampireHunter)) = value;
        }
      }

      public unsafe bool IsElite
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsElite));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsElite)) = value;
        }
      }

      public unsafe bool IsVBlood
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsVBlood));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_IsVBlood)) = value;
        }
      }

      public unsafe Nullable_Unboxed<float> BloodQuality
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_BloodQuality));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_BloodQuality), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabGUID BloodType
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_BloodType));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_BloodType)) = value;
        }
      }

      public unsafe ServantType ServantType
      {
        get
        {
          return *(ServantType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_ServantType));
        }
        [param: In] set
        {
          *(ServantType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_ServantType)) = value;
        }
      }

      public unsafe CharacterHUDEntryType PrefabType
      {
        get
        {
          return *(CharacterHUDEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_PrefabType));
        }
        [param: In] set
        {
          *(CharacterHUDEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParent.Data.NativeFieldInfoPtr_PrefabType)) = value;
        }
      }
    }
  }
}
