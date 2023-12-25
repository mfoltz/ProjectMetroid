// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUDEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUDEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthHUDShowFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameHUDShowFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastTimeHUDShowFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr__Segments_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Voice;
    private static readonly System.IntPtr NativeFieldInfoPtr_Merchant;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtection;
    private static readonly System.IntPtr NativeFieldInfoPtr_RootCanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousRootAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousRootScale;
    private static readonly System.IntPtr NativeFieldInfoPtr__OffsetY_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Segments_Public_get_SegmentFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Segments_Private_set_Void_SegmentFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OffsetY_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OffsetY_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe CharacterHUDEntry.SegmentFlag Segments
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 43842, RefRangeEnd = 43846, XrefRangeStart = 43842, XrefRangeEnd = 43846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_get_Segments_Public_get_SegmentFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CharacterHUDEntry.SegmentFlag*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 86269, RefRangeEnd = 86272, XrefRangeStart = 86269, XrefRangeEnd = 86272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_set_Segments_Private_set_Void_SegmentFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217482, XrefRangeEnd = 1217516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe float OffsetY
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_get_OffsetY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_set_OffsetY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217516, XrefRangeEnd = 1217552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupChunks(List<GameObject> chunkList, float maxValue, float valuePerChunk = 25f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &valuePerChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217552, XrefRangeEnd = 1217553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUDEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUDEntry()
    {
      Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUDEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr);
      CharacterHUDEntry.NativeFieldInfoPtr_EntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (EntryType));
      CharacterHUDEntry.NativeFieldInfoPtr_CharacterHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (CharacterHUDSettings));
      CharacterHUDEntry.NativeFieldInfoPtr_HealthHUDShowFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (HealthHUDShowFlag));
      CharacterHUDEntry.NativeFieldInfoPtr_NameHUDShowFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (NameHUDShowFlag));
      CharacterHUDEntry.NativeFieldInfoPtr_CastTimeHUDShowFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (CastTimeHUDShowFlag));
      CharacterHUDEntry.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Position));
      CharacterHUDEntry.NativeFieldInfoPtr__Segments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, "<Segments>k__BackingField");
      CharacterHUDEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Name));
      CharacterHUDEntry.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Health));
      CharacterHUDEntry.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Level));
      CharacterHUDEntry.NativeFieldInfoPtr_CastBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (CastBar));
      CharacterHUDEntry.NativeFieldInfoPtr_ProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (ProgressBar));
      CharacterHUDEntry.NativeFieldInfoPtr_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Blood));
      CharacterHUDEntry.NativeFieldInfoPtr_Voice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Voice));
      CharacterHUDEntry.NativeFieldInfoPtr_Merchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Merchant));
      CharacterHUDEntry.NativeFieldInfoPtr_Servant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Servant));
      CharacterHUDEntry.NativeFieldInfoPtr_JumpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (JumpDown));
      CharacterHUDEntry.NativeFieldInfoPtr_PvPProtection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (PvPProtection));
      CharacterHUDEntry.NativeFieldInfoPtr_RootCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (RootCanvasGroup));
      CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (PreviousRootAlpha));
      CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (PreviousRootScale));
      CharacterHUDEntry.NativeFieldInfoPtr__OffsetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, "<OffsetY>k__BackingField");
      CharacterHUDEntry.NativeMethodInfoPtr_get_Segments_Public_get_SegmentFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664307);
      CharacterHUDEntry.NativeMethodInfoPtr_set_Segments_Private_set_Void_SegmentFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664308);
      CharacterHUDEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664309);
      CharacterHUDEntry.NativeMethodInfoPtr_get_OffsetY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664310);
      CharacterHUDEntry.NativeMethodInfoPtr_set_OffsetY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664311);
      CharacterHUDEntry.NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664312);
      CharacterHUDEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, 100664313);
    }

    public CharacterHUDEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterHUDEntryType EntryType
    {
      get
      {
        return *(CharacterHUDEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_EntryType));
      }
      [param: In] set
      {
        *(CharacterHUDEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_EntryType)) = value;
      }
    }

    public unsafe CharacterHUDSettings CharacterHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CharacterHUDSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CharacterHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDShowFlag HealthHUDShowFlag
    {
      get
      {
        return *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_HealthHUDShowFlag));
      }
      [param: In] set
      {
        *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_HealthHUDShowFlag)) = value;
      }
    }

    public unsafe HUDShowFlag NameHUDShowFlag
    {
      get
      {
        return *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_NameHUDShowFlag));
      }
      [param: In] set
      {
        *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_NameHUDShowFlag)) = value;
      }
    }

    public unsafe HUDShowFlag CastTimeHUDShowFlag
    {
      get
      {
        return *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CastTimeHUDShowFlag));
      }
      [param: In] set
      {
        *(HUDShowFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CastTimeHUDShowFlag)) = value;
      }
    }

    public unsafe float3 Position
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe CharacterHUDEntry.SegmentFlag _Segments_k__BackingField
    {
      get
      {
        return *(CharacterHUDEntry.SegmentFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr__Segments_k__BackingField));
      }
      [param: In] set
      {
        *(CharacterHUDEntry.SegmentFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr__Segments_k__BackingField)) = value;
      }
    }

    public unsafe CharacterHUD_NameComponent Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_NameComponent) null : new CharacterHUD_NameComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_HealthComponent Health
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Health));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_HealthComponent) null : new CharacterHUD_HealthComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Health), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_LevelComponent Level
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Level));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_LevelComponent) null : new CharacterHUD_LevelComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Level), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_CastTimeComponent CastBar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CastBar));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_CastTimeComponent) null : new CharacterHUD_CastTimeComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_CastBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_ProgressBarComponent ProgressBar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_ProgressBar));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_ProgressBarComponent) null : new CharacterHUD_ProgressBarComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_ProgressBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_BloodComponent Blood
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Blood));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_BloodComponent) null : new CharacterHUD_BloodComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Blood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_VoiceComponent Voice
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Voice));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_VoiceComponent) null : new CharacterHUD_VoiceComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Voice), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_MerchantComponent Merchant
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Merchant));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_MerchantComponent) null : new CharacterHUD_MerchantComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Merchant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_ServantComponent Servant
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Servant));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_ServantComponent) null : new CharacterHUD_ServantComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_Servant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_JumpDownComponent JumpDown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_JumpDown));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_JumpDownComponent) null : new CharacterHUD_JumpDownComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_JumpDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_PvPProtectionComponent PvPProtection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PvPProtection));
        return pointer == System.IntPtr.Zero ? (CharacterHUD_PvPProtectionComponent) null : new CharacterHUD_PvPProtectionComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PvPProtection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup RootCanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_RootCanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_RootCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float PreviousRootAlpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootAlpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootAlpha)) = value;
      }
    }

    public unsafe Vector3 PreviousRootScale
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootScale));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr_PreviousRootScale)) = value;
      }
    }

    public unsafe float _OffsetY_k__BackingField
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr__OffsetY_k__BackingField));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntry.NativeFieldInfoPtr__OffsetY_k__BackingField)) = value;
      }
    }

    [Flags]
    public enum SegmentFlag
    {
      Name = 1,
      Health = 2,
      Level = 4,
      CastBar = 8,
      ProgressBar = 16, // 0x00000010
      Blood = 32, // 0x00000020
      JumpDown = 64, // 0x00000040
      Voice = 128, // 0x00000080
      PvPProtection = 256, // 0x00000100
      Servant = 512, // 0x00000200
      Merchant = 1024, // 0x00000400
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_ScreenPosNormalized;
      private static readonly System.IntPtr NativeFieldInfoPtr_Health;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecentDamageTakenFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastBarFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarPercentage;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedZoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarTypeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReservedColorId;
      private static readonly System.IntPtr NativeFieldInfoPtr_SmartClanName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsVampireHunter;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServantWithItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSpeaking;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsPvPProtected;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasAggro;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanJumpDown;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsLocalPlayer;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int LastFrame;
      [FieldOffset(12)]
      public quaternion Rotation;
      [FieldOffset(28)]
      public float3 Position;
      [FieldOffset(40)]
      public float ScreenPosNormalized;
      [FieldOffset(44)]
      public float Health;
      [FieldOffset(48)]
      public float MaxHealth;
      [FieldOffset(52)]
      public float HealthFill;
      [FieldOffset(56)]
      public float AbsorbFill;
      [FieldOffset(60)]
      public float RecoveryFill;
      [FieldOffset(64)]
      public float RecentDamageTakenFill;
      [FieldOffset(68)]
      public Nullable_Unboxed<float> CastBarFill;
      [FieldOffset(76)]
      public Nullable_Unboxed<float> LocalLevel;
      [FieldOffset(84)]
      public Nullable_Unboxed<float> EntityLevel;
      [FieldOffset(92)]
      public float ProgressBarPercentage;
      [FieldOffset(96)]
      public Nullable_Unboxed<float> BloodQuality;
      [FieldOffset(104)]
      public float NormalizedZoom;
      [FieldOffset(108)]
      public CharacterHUDEntryType PrefabType;
      [FieldOffset(112)]
      public Nullable_Unboxed<int> ProgressBarTypeId;
      [FieldOffset(120)]
      public PrefabGUID BloodType;
      [FieldOffset(124)]
      public CharacterHUDSettings.TeamType TeamType;
      [FieldOffset(128)]
      public int ReservedColorId;
      [FieldOffset(132)]
      public FixedString32 SmartClanName;
      [FieldOffset(164)]
      public FixedString64 Name;
      [FieldOffset(228)]
      public AssetGuid LocalizedName;
      [FieldOffset(244)]
      public PrefabGUID EntityPrefabGUID;
      [FieldOffset(248)]
      public bool IsVampireHunter;
      [FieldOffset(249)]
      public bool IsServantWithItems;
      [FieldOffset(250)]
      public bool IsSpeaking;
      [FieldOffset(251)]
      public bool IsPvPProtected;
      [FieldOffset(252)]
      public bool HasAggro;
      [FieldOffset(253)]
      public Nullable_Unboxed<bool> CanJumpDown;
      [FieldOffset(255)]
      public bool IsHovered;
      [FieldOffset(256)]
      public bool IsLocalPlayer;

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUDEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr);
        CharacterHUDEntry.Data.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (Entity));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_LastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (LastFrame));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (Rotation));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (Position));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_ScreenPosNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (ScreenPosNormalized));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (Health));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (MaxHealth));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_HealthFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (HealthFill));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_AbsorbFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (AbsorbFill));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_RecoveryFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (RecoveryFill));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_RecentDamageTakenFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (RecentDamageTakenFill));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_CastBarFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (CastBarFill));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_LocalLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (LocalLevel));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_EntityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (EntityLevel));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_ProgressBarPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (ProgressBarPercentage));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (BloodQuality));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_NormalizedZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (NormalizedZoom));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (PrefabType));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_ProgressBarTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (ProgressBarTypeId));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (BloodType));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (TeamType));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_ReservedColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (ReservedColorId));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_SmartClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (SmartClanName));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (Name));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (LocalizedName));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_EntityPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (EntityPrefabGUID));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsVampireHunter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsVampireHunter));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsServantWithItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsServantWithItems));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsSpeaking));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsPvPProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsPvPProtected));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_HasAggro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (HasAggro));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_CanJumpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (CanJumpDown));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsHovered));
        CharacterHUDEntry.Data.NativeFieldInfoPtr_IsLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, nameof (IsLocalPlayer));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUDEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
