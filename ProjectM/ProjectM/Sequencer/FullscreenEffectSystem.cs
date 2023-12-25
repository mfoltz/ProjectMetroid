// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.FullscreenEffectSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class FullscreenEffectSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__Active;
    private static readonly System.IntPtr NativeFieldInfoPtr__FadingOut;
    private static readonly System.IntPtr NativeFieldInfoPtr__VolumeParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Volumes;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFullscreenEffect_Public_Void_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortEntriesByImportance_Private_Int32_Entry_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntryExistsThisFrame_Private_Boolean_byref_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101046, XrefRangeEnd = 1101092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101095, RefRangeEnd = 1101096, XrefRangeStart = 1101092, XrefRangeEnd = 1101095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddFullscreenEffect(FullscreenEffectSystem.Entry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenEffectSystem.NativeMethodInfoPtr_AddFullscreenEffect_Public_Void_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101096, XrefRangeEnd = 1101104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101104, XrefRangeEnd = 1101198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101198, XrefRangeEnd = 1101200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int SortEntriesByImportance(
      FullscreenEffectSystem.Entry a,
      FullscreenEffectSystem.Entry b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullscreenEffectSystem.NativeMethodInfoPtr_SortEntriesByImportance_Private_Int32_Entry_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101208, RefRangeEnd = 1101209, XrefRangeStart = 1101200, XrefRangeEnd = 1101208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool EntryExistsThisFrame([In] ref FullscreenEffectSystem.Entry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullscreenEffectSystem.NativeMethodInfoPtr_EntryExistsThisFrame_Private_Boolean_byref_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenEffectSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenEffectSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenEffectSystem()
    {
      Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (FullscreenEffectSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr);
      FullscreenEffectSystem.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_Entries));
      FullscreenEffectSystem.NativeFieldInfoPtr__LastFrameEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_LastFrameEntries));
      FullscreenEffectSystem.NativeFieldInfoPtr__Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_Active));
      FullscreenEffectSystem.NativeFieldInfoPtr__FadingOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_FadingOut));
      FullscreenEffectSystem.NativeFieldInfoPtr__VolumeParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_VolumeParent));
      FullscreenEffectSystem.NativeFieldInfoPtr__Volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (_Volumes));
      FullscreenEffectSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687374);
      FullscreenEffectSystem.NativeMethodInfoPtr_AddFullscreenEffect_Public_Void_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687375);
      FullscreenEffectSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687376);
      FullscreenEffectSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687377);
      FullscreenEffectSystem.NativeMethodInfoPtr_SortEntriesByImportance_Private_Int32_Entry_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687378);
      FullscreenEffectSystem.NativeMethodInfoPtr_EntryExistsThisFrame_Private_Boolean_byref_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687379);
      FullscreenEffectSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687380);
      FullscreenEffectSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, 100687381);
    }

    public FullscreenEffectSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<FullscreenEffectSystem.Entry> _Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Entries));
        return pointer == System.IntPtr.Zero ? (List<FullscreenEffectSystem.Entry>) null : new List<FullscreenEffectSystem.Entry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullscreenEffectSystem.Entry> _LastFrameEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__LastFrameEntries));
        return pointer == System.IntPtr.Zero ? (List<FullscreenEffectSystem.Entry>) null : new List<FullscreenEffectSystem.Entry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__LastFrameEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullscreenEffectSystem.Active> _Active
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Active));
        return pointer == System.IntPtr.Zero ? (List<FullscreenEffectSystem.Active>) null : new List<FullscreenEffectSystem.Active>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullscreenEffectSystem.FadeOut> _FadingOut
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__FadingOut));
        return pointer == System.IntPtr.Zero ? (List<FullscreenEffectSystem.FadeOut>) null : new List<FullscreenEffectSystem.FadeOut>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__FadingOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _VolumeParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__VolumeParent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__VolumeParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Volume> _Volumes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Volumes));
        return pointer == System.IntPtr.Zero ? (List<Volume>) null : new List<Volume>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.NativeFieldInfoPtr__Volumes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Entry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_VolumeProfile;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeFieldInfoPtr_FadeInTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;

      static Entry()
      {
        Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr);
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_VolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (VolumeProfile));
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (Importance));
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (StartTime));
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (Weight));
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (FadeInTime));
        FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, nameof (FadeOutTime));
      }

      public Entry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Entry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullscreenEffectSystem.Entry>.NativeClassPtr, data));
      }

      public unsafe VolumeProfile VolumeProfile
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_VolumeProfile));
          return pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_VolumeProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe float Weight
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_Weight)) = value;
        }
      }

      public unsafe float FadeInTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeInTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeInTime)) = value;
        }
      }

      public unsafe float FadeOutTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeOutTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Entry.NativeFieldInfoPtr_FadeOutTime)) = value;
        }
      }
    }

    public sealed class Active : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_VolumeProfile;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

      static Active()
      {
        Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (Active));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr);
        FullscreenEffectSystem.Active.NativeFieldInfoPtr_VolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr, nameof (VolumeProfile));
        FullscreenEffectSystem.Active.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr, nameof (Weight));
      }

      public Active(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Active()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullscreenEffectSystem.Active>.NativeClassPtr, data));
      }

      public unsafe VolumeProfile VolumeProfile
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Active.NativeFieldInfoPtr_VolumeProfile));
          return pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Active.NativeFieldInfoPtr_VolumeProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Weight
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Active.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.Active.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }

    public sealed class FadeOut : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_VolumeProfile;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartFadeOutTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;

      static FadeOut()
      {
        Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenEffectSystem>.NativeClassPtr, nameof (FadeOut));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr);
        FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_VolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, nameof (VolumeProfile));
        FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, nameof (Weight));
        FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_StartFadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, nameof (StartFadeOutTime));
        FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, nameof (FadeOutTime));
      }

      public FadeOut(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FadeOut()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullscreenEffectSystem.FadeOut>.NativeClassPtr, data));
      }

      public unsafe VolumeProfile VolumeProfile
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_VolumeProfile));
          return pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_VolumeProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Weight
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_Weight)) = value;
        }
      }

      public unsafe float StartFadeOutTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_StartFadeOutTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_StartFadeOutTime)) = value;
        }
      }

      public unsafe float FadeOutTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_FadeOutTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectSystem.FadeOut.NativeFieldInfoPtr_FadeOutTime)) = value;
        }
      }
    }
  }
}
