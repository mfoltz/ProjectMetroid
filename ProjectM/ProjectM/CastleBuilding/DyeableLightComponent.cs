// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeableLightComponent
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
namespace ProjectM.CastleBuilding
{
  public class DyeableLightComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightSwatchSetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalLightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevActiveIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasRecordedOriginalLightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSortedSwatchSetupFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortSwatchSetupFlags_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129418, RefRangeEnd = 1129419, XrefRangeStart = 1129392, XrefRangeEnd = 1129418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SortSwatchSetupFlags()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableLightComponent.NativeMethodInfoPtr_SortSwatchSetupFlags_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1129459, RefRangeEnd = 1129461, XrefRangeStart = 1129419, XrefRangeEnd = 1129459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActiveIndex(int activeIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &activeIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableLightComponent.NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129461, XrefRangeEnd = 1129470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DyeableLightComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableLightComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DyeableLightComponent()
    {
      Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeableLightComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr);
      DyeableLightComponent.NativeFieldInfoPtr_ColorSwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (ColorSwatch));
      DyeableLightComponent.NativeFieldInfoPtr_LightSwatchSetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (LightSwatchSetupFlags));
      DyeableLightComponent.NativeFieldInfoPtr_OriginalLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (OriginalLightColor));
      DyeableLightComponent.NativeFieldInfoPtr_ActiveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (ActiveIndex));
      DyeableLightComponent.NativeFieldInfoPtr_PrevActiveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (PrevActiveIndex));
      DyeableLightComponent.NativeFieldInfoPtr_HasRecordedOriginalLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (HasRecordedOriginalLightColor));
      DyeableLightComponent.NativeFieldInfoPtr_HasSortedSwatchSetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, nameof (HasSortedSwatchSetupFlags));
      DyeableLightComponent.NativeMethodInfoPtr_SortSwatchSetupFlags_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, 100689750);
      DyeableLightComponent.NativeMethodInfoPtr_SetActiveIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, 100689751);
      DyeableLightComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, 100689752);
    }

    public DyeableLightComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenuDyeSwatchCollectionAsset ColorSwatch
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_ColorSwatch));
        return pointer == System.IntPtr.Zero ? (BuildMenuDyeSwatchCollectionAsset) null : new BuildMenuDyeSwatchCollectionAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_ColorSwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ProjectM.CastleBuilding.LightSwatchSetupFlags> LightSwatchSetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_LightSwatchSetupFlags));
        return pointer == System.IntPtr.Zero ? (List<ProjectM.CastleBuilding.LightSwatchSetupFlags>) null : new List<ProjectM.CastleBuilding.LightSwatchSetupFlags>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_LightSwatchSetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color OriginalLightColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_OriginalLightColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_OriginalLightColor)) = value;
      }
    }

    public unsafe int ActiveIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_ActiveIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_ActiveIndex)) = value;
      }
    }

    public unsafe int PrevActiveIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_PrevActiveIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_PrevActiveIndex)) = value;
      }
    }

    public unsafe bool HasRecordedOriginalLightColor
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_HasRecordedOriginalLightColor));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_HasRecordedOriginalLightColor)) = value;
      }
    }

    public unsafe bool HasSortedSwatchSetupFlags
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_HasSortedSwatchSetupFlags));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableLightComponent.NativeFieldInfoPtr_HasSortedSwatchSetupFlags)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DyeableLightComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SortSwatchSetupFlags_b__7_0_Internal_Int32_LightSwatchSetupFlags_LightSwatchSetupFlags_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeableLightComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129390, XrefRangeEnd = 1129392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SortSwatchSetupFlags_b__7_0(
        ProjectM.CastleBuilding.LightSwatchSetupFlags x,
        ProjectM.CastleBuilding.LightSwatchSetupFlags y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyeableLightComponent.__c.NativeMethodInfoPtr__SortSwatchSetupFlags_b__7_0_Internal_Int32_LightSwatchSetupFlags_LightSwatchSetupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeableLightComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr);
        DyeableLightComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr, "<>9");
        DyeableLightComponent.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr, "<>9__7_0");
        DyeableLightComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr, 100689754);
        DyeableLightComponent.__c.NativeMethodInfoPtr__SortSwatchSetupFlags_b__7_0_Internal_Int32_LightSwatchSetupFlags_LightSwatchSetupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableLightComponent.__c>.NativeClassPtr, 100689755);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DyeableLightComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableLightComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DyeableLightComponent.__c) null : new DyeableLightComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableLightComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<ProjectM.CastleBuilding.LightSwatchSetupFlags> __9__7_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableLightComponent.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ProjectM.CastleBuilding.LightSwatchSetupFlags>) null : new Il2CppSystem.Comparison<ProjectM.CastleBuilding.LightSwatchSetupFlags>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableLightComponent.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
