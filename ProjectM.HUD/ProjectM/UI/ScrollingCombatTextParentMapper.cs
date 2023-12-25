// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ScrollingCombatTextParentMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  public class ScrollingCombatTextParentMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275259, XrefRangeEnd = 1275270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275270, XrefRangeEnd = 1275273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275273, XrefRangeEnd = 1275299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScrollingCombatTextParentMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScrollingCombatTextParentMapper()
    {
      Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ScrollingCombatTextParentMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr);
      ScrollingCombatTextParentMapper.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, nameof (_Elements));
      ScrollingCombatTextParentMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ScrollingCombatTextParentMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, nameof (_GameDataSystem));
      ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, 100668435);
      ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, 100668436);
      ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, 100668437);
      ScrollingCombatTextParentMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, 100668438);
      ScrollingCombatTextParentMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, 100668439);
    }

    public ScrollingCombatTextParentMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntryGroup<SCTText, ScrollingCombatTextParentMapper.EntryData> _Elements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__Elements));
        return pointer == System.IntPtr.Zero ? (EntryGroup<SCTText, ScrollingCombatTextParentMapper.EntryData>) null : new EntryGroup<SCTText, ScrollingCombatTextParentMapper.EntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__Elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct EntryData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_CameraRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideLocalizedText;
      private static readonly System.IntPtr NativeFieldInfoPtr_RandomXZDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_RandomXZForce;
      private static readonly System.IntPtr NativeFieldInfoPtr_SourceDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_SourceTypeText;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideText;
      [FieldOffset(0)]
      public float Value;
      [FieldOffset(4)]
      public float3 Position;
      [FieldOffset(16)]
      public float NormalizedTime;
      [FieldOffset(20)]
      public PrefabGUID Type;
      [FieldOffset(24)]
      public quaternion CameraRotation;
      [FieldOffset(40)]
      public float3 OverrideColor;
      [FieldOffset(52)]
      public AssetGuid OverrideLocalizedText;
      [FieldOffset(68)]
      public float3 RandomXZDirection;
      [FieldOffset(80)]
      public float RandomXZForce;
      [FieldOffset(84)]
      public float3 SourceDirection;
      [FieldOffset(96)]
      public FixedString128 SourceTypeText;
      [FieldOffset(224)]
      public float BloodQuality;
      [FieldOffset(228)]
      public Entity Target;
      [FieldOffset(236)]
      public FixedString512 OverrideText;

      static EntryData()
      {
        Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, nameof (EntryData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr);
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (Value));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (Position));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (NormalizedTime));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (Type));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_CameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (CameraRotation));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (OverrideColor));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_OverrideLocalizedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (OverrideLocalizedText));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_RandomXZDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (RandomXZDirection));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_RandomXZForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (RandomXZForce));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_SourceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (SourceDirection));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_SourceTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (SourceTypeText));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (BloodQuality));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (Target));
        ScrollingCombatTextParentMapper.EntryData.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, nameof (OverrideText));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.EntryData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.ScrollingCombatTextParentMapper/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_SCTText_EntryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275217, XrefRangeEnd = 1275250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, UICanvasBase canvas)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275250, XrefRangeEnd = 1275257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        SCTText element,
        ScrollingCombatTextParentMapper.EntryData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_SCTText_EntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr);
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, nameof (gameDataSystem));
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, "<>9__2");
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, 100668440);
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, 100668441);
        ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_SCTText_EntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c__DisplayClass5_0>.NativeClassPtr, 100668442);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ScrollingCombatTextParentMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ScrollingCombatTextParentMapper) null : new ScrollingCombatTextParentMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData> __9__2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___9__2));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData>) null : new Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParentMapper.__c__DisplayClass5_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ScrollingCombatTextParentMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_1_Internal_Void_SCTText_EntryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275257, XrefRangeEnd = 1275259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5_1(
        SCTText element,
        ScrollingCombatTextParentMapper.EntryData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParentMapper.__c.NativeMethodInfoPtr__OnUpdate_b__5_1_Internal_Void_SCTText_EntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollingCombatTextParentMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr);
        ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr, "<>9");
        ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr, "<>9__5_1");
        ScrollingCombatTextParentMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr, 100668444);
        ScrollingCombatTextParentMapper.__c.NativeMethodInfoPtr__OnUpdate_b__5_1_Internal_Void_SCTText_EntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParentMapper.__c>.NativeClassPtr, 100668445);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ScrollingCombatTextParentMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ScrollingCombatTextParentMapper.__c) null : new ScrollingCombatTextParentMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData> __9__5_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData>) null : new Il2CppSystem.Action<SCTText, ScrollingCombatTextParentMapper.EntryData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScrollingCombatTextParentMapper.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
