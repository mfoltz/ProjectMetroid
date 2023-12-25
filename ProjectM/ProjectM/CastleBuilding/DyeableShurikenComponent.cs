// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeableShurikenComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class DyeableShurikenComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchSetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchFlagOffsetData;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalGradients;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr_Renderers;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevActiveIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasInitializedOffsetBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitOffsetBuffer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeRenderers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1129529, RefRangeEnd = 1129531, XrefRangeStart = 1129470, XrefRangeEnd = 1129529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildOffsetBuffer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129531, XrefRangeEnd = 1129539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitOffsetBuffer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.NativeMethodInfoPtr_InitOffsetBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129539, XrefRangeEnd = 1129543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeRenderers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.NativeMethodInfoPtr_InitializeRenderers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1129710, RefRangeEnd = 1129714, XrefRangeStart = 1129543, XrefRangeEnd = 1129710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActiveIndex(int activeIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &activeIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129714, XrefRangeEnd = 1129750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DyeableShurikenComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DyeableShurikenComponent()
    {
      Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeableShurikenComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr);
      DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (ColorSwatch));
      DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (ColorSwatchSetupFlags));
      DyeableShurikenComponent.NativeFieldInfoPtr_SetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (SetupFlags));
      DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (ColorSwatchFlagOffsetData));
      DyeableShurikenComponent.NativeFieldInfoPtr_OriginalGradients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (OriginalGradients));
      DyeableShurikenComponent.NativeFieldInfoPtr_ParticleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (ParticleSystems));
      DyeableShurikenComponent.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (Renderers));
      DyeableShurikenComponent.NativeFieldInfoPtr_ActiveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (ActiveIndex));
      DyeableShurikenComponent.NativeFieldInfoPtr_PrevActiveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (PrevActiveIndex));
      DyeableShurikenComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, nameof (HasInitializedOffsetBuffer));
      DyeableShurikenComponent.NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, 100689757);
      DyeableShurikenComponent.NativeMethodInfoPtr_InitOffsetBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, 100689758);
      DyeableShurikenComponent.NativeMethodInfoPtr_InitializeRenderers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, 100689759);
      DyeableShurikenComponent.NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, 100689760);
      DyeableShurikenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, 100689761);
    }

    public DyeableShurikenComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenuDyeSwatchCollectionAsset ColorSwatch
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatch));
        return pointer == System.IntPtr.Zero ? (BuildMenuDyeSwatchCollectionAsset) null : new BuildMenuDyeSwatchCollectionAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SwatchSetupFlags> ColorSwatchSetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SwatchSetupFlags>) null : new List<SwatchSetupFlags>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SetupFlag> SetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_SetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SetupFlag>) null : new List<SetupFlag>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_SetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OffsetData> ColorSwatchFlagOffsetData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData));
        return pointer == System.IntPtr.Zero ? (List<OffsetData>) null : new List<OffsetData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, ParticleSystem.MinMaxGradient> OriginalGradients
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_OriginalGradients));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, ParticleSystem.MinMaxGradient>) null : new Dictionary<int, ParticleSystem.MinMaxGradient>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_OriginalGradients), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, ParticleSystem> ParticleSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ParticleSystems));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, ParticleSystem>) null : new Dictionary<int, ParticleSystem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ParticleSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Renderer> Renderers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_Renderers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Renderer>) null : new Il2CppReferenceArray<Renderer>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int ActiveIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ActiveIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_ActiveIndex)) = value;
      }
    }

    public unsafe int PrevActiveIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_PrevActiveIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_PrevActiveIndex)) = value;
      }
    }

    public unsafe bool HasInitializedOffsetBuffer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableShurikenComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DyeableShurikenComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildOffsetBuffer_b__10_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _BuildOffsetBuffer_b__10_0(SwatchSetupFlags x, SwatchSetupFlags y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyeableShurikenComponent.__c.NativeMethodInfoPtr__BuildOffsetBuffer_b__10_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeableShurikenComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr);
        DyeableShurikenComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr, "<>9");
        DyeableShurikenComponent.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr, "<>9__10_0");
        DyeableShurikenComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr, 100689763);
        DyeableShurikenComponent.__c.NativeMethodInfoPtr__BuildOffsetBuffer_b__10_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableShurikenComponent.__c>.NativeClassPtr, 100689764);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DyeableShurikenComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableShurikenComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DyeableShurikenComponent.__c) null : new DyeableShurikenComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableShurikenComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SwatchSetupFlags> __9__10_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableShurikenComponent.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SwatchSetupFlags>) null : new Il2CppSystem.Comparison<SwatchSetupFlags>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableShurikenComponent.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
