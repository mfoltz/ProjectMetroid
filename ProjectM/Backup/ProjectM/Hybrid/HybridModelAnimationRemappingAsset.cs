// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelAnimationRemappingAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelAnimationRemappingAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SourceCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestinationCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationMaps;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157400, XrefRangeEnd = 1157408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelAnimationRemappingAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationRemappingAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelAnimationRemappingAsset()
    {
      Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelAnimationRemappingAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr);
      HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_SourceCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr, nameof (SourceCollection));
      HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_DestinationCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr, nameof (DestinationCollection));
      HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_AnimationMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr, nameof (AnimationMaps));
      HybridModelAnimationRemappingAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr, 100692132);
    }

    public HybridModelAnimationRemappingAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AnimationCollection SourceCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_SourceCollection));
        return pointer == System.IntPtr.Zero ? (AnimationCollection) null : new AnimationCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_SourceCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection DestinationCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_DestinationCollection));
        return pointer == System.IntPtr.Zero ? (AnimationCollection) null : new AnimationCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_DestinationCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HybridModelAnimationRemappingAsset.AnimationMapping> AnimationMaps
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_AnimationMaps));
        return pointer == System.IntPtr.Zero ? (List<HybridModelAnimationRemappingAsset.AnimationMapping>) null : new List<HybridModelAnimationRemappingAsset.AnimationMapping>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.NativeFieldInfoPtr_AnimationMaps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class AnimationMapping : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Source;
      private static readonly System.IntPtr NativeFieldInfoPtr_Destination;
      private static readonly System.IntPtr NativeFieldInfoPtr_Layer;

      static AnimationMapping()
      {
        Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset>.NativeClassPtr, nameof (AnimationMapping));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr);
        HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr, nameof (Source));
        HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr, nameof (Destination));
        HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr, nameof (Layer));
      }

      public AnimationMapping(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AnimationMapping()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelAnimationRemappingAsset.AnimationMapping>.NativeClassPtr, data));
      }

      public unsafe string Source
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Source)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Source), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Destination
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Destination)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Destination), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int Layer
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Layer));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationRemappingAsset.AnimationMapping.NativeFieldInfoPtr_Layer)) = value;
        }
      }
    }
  }
}
