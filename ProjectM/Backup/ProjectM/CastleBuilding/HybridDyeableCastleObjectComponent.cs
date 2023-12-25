// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.HybridDyeableCastleObjectComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class HybridDyeableCastleObjectComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchSetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchFlagOffsetData;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasInitializedOffsetBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitOffsetBuffer_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129873, RefRangeEnd = 1129874, XrefRangeStart = 1129814, XrefRangeEnd = 1129873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildOffsetBuffer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129875, RefRangeEnd = 1129876, XrefRangeStart = 1129874, XrefRangeEnd = 1129875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitOffsetBuffer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_InitOffsetBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129876, XrefRangeEnd = 1129887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129887, XrefRangeEnd = 1129909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridDyeableCastleObjectComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridDyeableCastleObjectComponent()
    {
      Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (HybridDyeableCastleObjectComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr);
      HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, nameof (ColorSwatch));
      HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, nameof (ColorSwatchSetupFlags));
      HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_SetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, nameof (SetupFlags));
      HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, nameof (ColorSwatchFlagOffsetData));
      HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, nameof (HasInitializedOffsetBuffer));
      HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_BuildOffsetBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, 100689775);
      HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_InitOffsetBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, 100689776);
      HybridDyeableCastleObjectComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, 100689777);
      HybridDyeableCastleObjectComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, 100689778);
    }

    public HybridDyeableCastleObjectComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenuDyeSwatchCollectionAsset ColorSwatch
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatch));
        return pointer == System.IntPtr.Zero ? (BuildMenuDyeSwatchCollectionAsset) null : new BuildMenuDyeSwatchCollectionAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SwatchSetupFlags> ColorSwatchSetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SwatchSetupFlags>) null : new List<SwatchSetupFlags>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchSetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SetupFlag> SetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_SetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SetupFlag>) null : new List<SetupFlag>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_SetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OffsetData> ColorSwatchFlagOffsetData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData));
        return pointer == System.IntPtr.Zero ? (List<OffsetData>) null : new List<OffsetData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_ColorSwatchFlagOffsetData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool HasInitializedOffsetBuffer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridDyeableCastleObjectComponent.NativeFieldInfoPtr_HasInitializedOffsetBuffer)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.HybridDyeableCastleObjectComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildOffsetBuffer_b__5_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _BuildOffsetBuffer_b__5_0(SwatchSetupFlags x, SwatchSetupFlags y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectComponent.__c.NativeMethodInfoPtr__BuildOffsetBuffer_b__5_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr);
        HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr, "<>9");
        HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr, "<>9__5_0");
        HybridDyeableCastleObjectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr, 100689780);
        HybridDyeableCastleObjectComponent.__c.NativeMethodInfoPtr__BuildOffsetBuffer_b__5_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectComponent.__c>.NativeClassPtr, 100689781);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe HybridDyeableCastleObjectComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (HybridDyeableCastleObjectComponent.__c) null : new HybridDyeableCastleObjectComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SwatchSetupFlags> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SwatchSetupFlags>) null : new Il2CppSystem.Comparison<SwatchSetupFlags>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridDyeableCastleObjectComponent.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
