// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeableCastleObjectAuthoring_Conversion
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

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class DyeableCastleObjectAuthoring_Conversion : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UDIMShader2;
    private static readonly System.IntPtr NativeFieldInfoPtr_UDIMShader3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Udim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Udim3;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FillAndSetupMeshDyeBufferRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_List_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129257, XrefRangeEnd = 1129283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1129388, RefRangeEnd = 1129390, XrefRangeStart = 1129283, XrefRangeEnd = 1129388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FillAndSetupMeshDyeBufferRecursively(
      GameObjectConversionSystem conversionSystem,
      GameObject gameObject,
      List<Entity> meshEntities,
      List<Entity> proxyEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshEntities);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) proxyEntities);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_FillAndSetupMeshDyeBufferRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_List_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DyeableCastleObjectAuthoring_Conversion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DyeableCastleObjectAuthoring_Conversion()
    {
      Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeableCastleObjectAuthoring_Conversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr);
      DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, nameof (UDIMShader2));
      DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, nameof (UDIMShader3));
      DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, nameof (Udim2));
      DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, nameof (Udim3));
      DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, 100689742);
      DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_FillAndSetupMeshDyeBufferRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, 100689743);
      DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, 100689744);
      DyeableCastleObjectAuthoring_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, 100689746);
    }

    public DyeableCastleObjectAuthoring_Conversion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string UDIMShader2
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader2, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader2, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UDIMShader3
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader3, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_UDIMShader3, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Shader Udim2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Shader Udim3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring_Conversion.NativeFieldInfoPtr_Udim3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DyeableCastleObjectAuthoring_Conversion/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_meshEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_proxyEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DyeableCastleObjectAuthoring_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129199, XrefRangeEnd = 1129257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(DyeableCastleObjectAuthoring dyeComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dyeComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DyeableCastleObjectAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr);
        DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_meshEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr, nameof (meshEntities));
        DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_proxyEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr, nameof (proxyEntities));
        DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr, 100689747);
        DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DyeableCastleObjectAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0>.NativeClassPtr, 100689748);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe DyeableCastleObjectAuthoring_Conversion __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DyeableCastleObjectAuthoring_Conversion) null : new DyeableCastleObjectAuthoring_Conversion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<Entity> meshEntities
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_meshEntities));
          return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_meshEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<Entity> proxyEntities
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_proxyEntities));
          return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring_Conversion.__c__DisplayClass4_0.NativeFieldInfoPtr_proxyEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
