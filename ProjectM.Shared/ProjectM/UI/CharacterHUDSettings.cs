// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUDSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUDSettings : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TeamHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnemyTeamHudSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDifferenceColorsData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxXRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxYRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlphaZoomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScaleZoomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetYZoomSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTeamHUDSetting_Public_TeamHUDSetting_TeamType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTeamType_Public_Static_TeamType_Entity_Team_Entity_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794827, RefRangeEnd = 794829, XrefRangeStart = 794824, XrefRangeEnd = 794827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUDSettings.TeamHUDSetting GetTeamHUDSetting(
      CharacterHUDSettings.TeamType teamType,
      int reservedEnemyColorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &teamType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &reservedEnemyColorId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.NativeMethodInfoPtr_GetTeamHUDSetting_Public_TeamHUDSetting_TeamType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CharacterHUDSettings.TeamHUDSetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794830, RefRangeEnd = 794832, XrefRangeStart = 794829, XrefRangeEnd = 794830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CharacterHUDSettings.TeamType GetTeamType(
      Entity localPlayer,
      Team localTeam,
      Entity entity,
      Team team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &team;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.NativeMethodInfoPtr_GetTeamType_Public_Static_TeamType_Entity_Team_Entity_Team_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CharacterHUDSettings.TeamType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUDSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUDSettings()
    {
      Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (CharacterHUDSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr);
      CharacterHUDSettings.NativeFieldInfoPtr_TeamHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (TeamHUDSettings));
      CharacterHUDSettings.NativeFieldInfoPtr_EnemyTeamHudSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (EnemyTeamHudSettings));
      CharacterHUDSettings.NativeFieldInfoPtr_LevelDifferenceColorsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (LevelDifferenceColorsData));
      CharacterHUDSettings.NativeFieldInfoPtr_MaxXRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (MaxXRotation));
      CharacterHUDSettings.NativeFieldInfoPtr_MaxYRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (MaxYRotation));
      CharacterHUDSettings.NativeFieldInfoPtr_MaxZRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (MaxZRotation));
      CharacterHUDSettings.NativeFieldInfoPtr_AlphaZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (AlphaZoomSettings));
      CharacterHUDSettings.NativeFieldInfoPtr_ScaleZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (ScaleZoomSettings));
      CharacterHUDSettings.NativeFieldInfoPtr_OffsetYZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (OffsetYZoomSettings));
      CharacterHUDSettings.NativeMethodInfoPtr_GetTeamHUDSetting_Public_TeamHUDSetting_TeamType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, 100670079);
      CharacterHUDSettings.NativeMethodInfoPtr_GetTeamType_Public_Static_TeamType_Entity_Team_Entity_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, 100670080);
      CharacterHUDSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, 100670081);
    }

    public CharacterHUDSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CharacterHUDSettings.TeamHUDSetting> TeamHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_TeamHUDSettings));
        return pointer == System.IntPtr.Zero ? (List<CharacterHUDSettings.TeamHUDSetting>) null : new List<CharacterHUDSettings.TeamHUDSetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_TeamHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CharacterHUDSettings.TeamHUDSetting> EnemyTeamHudSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_EnemyTeamHudSettings));
        return pointer == System.IntPtr.Zero ? (List<CharacterHUDSettings.TeamHUDSetting>) null : new List<CharacterHUDSettings.TeamHUDSetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_EnemyTeamHudSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDSettings.LevelDifferenceColors LevelDifferenceColorsData
    {
      get
      {
        return *(CharacterHUDSettings.LevelDifferenceColors*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_LevelDifferenceColorsData));
      }
      [param: In] set
      {
        *(CharacterHUDSettings.LevelDifferenceColors*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_LevelDifferenceColorsData)) = value;
      }
    }

    public unsafe float MaxXRotation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxXRotation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxXRotation)) = value;
      }
    }

    public unsafe float MaxYRotation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxYRotation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxYRotation)) = value;
      }
    }

    public unsafe float MaxZRotation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxZRotation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_MaxZRotation)) = value;
      }
    }

    public CharacterHUDSettings.ZoomSettings AlphaZoomSettings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_AlphaZoomSettings);
        return new CharacterHUDSettings.ZoomSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_AlphaZoomSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public CharacterHUDSettings.ZoomSettings ScaleZoomSettings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_ScaleZoomSettings);
        return new CharacterHUDSettings.ZoomSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_ScaleZoomSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public CharacterHUDSettings.ZoomSettings OffsetYZoomSettings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_OffsetYZoomSettings);
        return new CharacterHUDSettings.ZoomSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.NativeFieldInfoPtr_OffsetYZoomSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LevelDifferenceColors
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff_Less;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff_Even;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff_Above1;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff_Above2;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff_Above3OrMore;
      [FieldOffset(0)]
      public Color LevelDiff_Less;
      [FieldOffset(16)]
      public Color LevelDiff_Even;
      [FieldOffset(32)]
      public Color LevelDiff_Above1;
      [FieldOffset(48)]
      public Color LevelDiff_Above2;
      [FieldOffset(64)]
      public Color LevelDiff_Above3OrMore;

      static LevelDifferenceColors()
      {
        Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (LevelDifferenceColors));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr);
        CharacterHUDSettings.LevelDifferenceColors.NativeFieldInfoPtr_LevelDiff_Less = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, nameof (LevelDiff_Less));
        CharacterHUDSettings.LevelDifferenceColors.NativeFieldInfoPtr_LevelDiff_Even = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, nameof (LevelDiff_Even));
        CharacterHUDSettings.LevelDifferenceColors.NativeFieldInfoPtr_LevelDiff_Above1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, nameof (LevelDiff_Above1));
        CharacterHUDSettings.LevelDifferenceColors.NativeFieldInfoPtr_LevelDiff_Above2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, nameof (LevelDiff_Above2));
        CharacterHUDSettings.LevelDifferenceColors.NativeFieldInfoPtr_LevelDiff_Above3OrMore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, nameof (LevelDiff_Above3OrMore));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.LevelDifferenceColors>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum TeamType
    {
      LocalPlayer,
      LocalTeam,
      Enemy,
      Neutral,
      Resource,
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct TeamHUDSetting
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_FrameColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_NameColor;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TeamHUDSetting_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public CharacterHUDSettings.TeamType TeamType;
      [FieldOffset(4)]
      public Color FrameColor;
      [FieldOffset(20)]
      public Color HealthColor;
      [FieldOffset(36)]
      public Color DamageColor;
      [FieldOffset(52)]
      public Color NameColor;

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 794801, RefRangeEnd = 794804, XrefRangeStart = 794796, XrefRangeEnd = 794801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUDSettings.TeamHUDSetting other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TeamHUDSetting_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794804, XrefRangeEnd = 794808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 794812, RefRangeEnd = 794814, XrefRangeStart = 794808, XrefRangeEnd = 794812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TeamHUDSetting()
      {
        Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (TeamHUDSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr);
        CharacterHUDSettings.TeamHUDSetting.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, nameof (TeamType));
        CharacterHUDSettings.TeamHUDSetting.NativeFieldInfoPtr_FrameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, nameof (FrameColor));
        CharacterHUDSettings.TeamHUDSetting.NativeFieldInfoPtr_HealthColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, nameof (HealthColor));
        CharacterHUDSettings.TeamHUDSetting.NativeFieldInfoPtr_DamageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, nameof (DamageColor));
        CharacterHUDSettings.TeamHUDSetting.NativeFieldInfoPtr_NameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, nameof (NameColor));
        CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TeamHUDSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, 100670082);
        CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, 100670083);
        CharacterHUDSettings.TeamHUDSetting.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, 100670084);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.TeamHUDSetting>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    public sealed class ZoomSettings : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MinThreshhold;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxThreshhold;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
      private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 794815, RefRangeEnd = 794824, XrefRangeStart = 794814, XrefRangeEnd = 794815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float Evaluate(float normalizedZoom)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &normalizedZoom;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDSettings.ZoomSettings.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ZoomSettings()
      {
        Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUDSettings>.NativeClassPtr, nameof (ZoomSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr);
        CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinThreshhold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, nameof (MinThreshhold));
        CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxThreshhold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, nameof (MaxThreshhold));
        CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, nameof (MinFactor));
        CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, nameof (MaxFactor));
        CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, nameof (Curve));
        CharacterHUDSettings.ZoomSettings.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, 100670085);
      }

      public ZoomSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ZoomSettings()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDSettings.ZoomSettings>.NativeClassPtr, data));
      }

      public unsafe float MinThreshhold
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinThreshhold));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinThreshhold)) = value;
        }
      }

      public unsafe float MaxThreshhold
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxThreshhold));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxThreshhold)) = value;
        }
      }

      public unsafe float MinFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MinFactor)) = value;
        }
      }

      public unsafe float MaxFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_MaxFactor)) = value;
        }
      }

      public unsafe AnimationCurve Curve
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_Curve));
          return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDSettings.ZoomSettings.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
