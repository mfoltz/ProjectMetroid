// Decompiled with JetBrains decompiler
// Type: ProjectM.SubSceneNetworkedPrefabConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SubSceneNetworkedPrefabConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IRegisterStaticTransformTypes_RegisterRequiredTypes_Private_Virtual_Final_New_Void_StaticTransformIndexConversion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039972, XrefRangeEnd = 1039976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_IRegisterStaticTransformTypes_RegisterRequiredTypes(
      StaticTransformIndexConversion transformIndexingConversion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformIndexingConversion);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_ProjectM_IRegisterStaticTransformTypes_RegisterRequiredTypes_Private_Virtual_Final_New_Void_StaticTransformIndexConversion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039976, XrefRangeEnd = 1040019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubSceneNetworkedPrefabConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SubSceneNetworkedPrefabConversionSystem()
    {
      Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SubSceneNetworkedPrefabConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr);
      SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_ProjectM_IRegisterStaticTransformTypes_RegisterRequiredTypes_Private_Virtual_Final_New_Void_StaticTransformIndexConversion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr, 100681440);
      SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr, 100681441);
      SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr, 100681442);
      SubSceneNetworkedPrefabConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr, 100681443);
    }

    public SubSceneNetworkedPrefabConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.SubSceneNetworkedPrefabConversionSystem/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_transformIndexingConversion;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_PrefabGuidComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039888, XrefRangeEnd = 1039972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        NetworkedComponent prefabComponent,
        PrefabGuidComponent prefabGuidComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabComponent);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuidComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr);
        SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_transformIndexingConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (transformIndexingConversion));
        SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
        SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_gameObjectLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (gameObjectLookup));
        SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr, 100681444);
        SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0>.NativeClassPtr, 100681445);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe StaticTransformIndexConversion transformIndexingConversion
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_transformIndexingConversion));
          return pointer == System.IntPtr.Zero ? (StaticTransformIndexConversion) null : new StaticTransformIndexConversion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_transformIndexingConversion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SubSceneNetworkedPrefabConversionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SubSceneNetworkedPrefabConversionSystem) null : new SubSceneNetworkedPrefabConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameObjectLookupConversionSystem gameObjectLookup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_gameObjectLookup));
          return pointer == System.IntPtr.Zero ? (GameObjectLookupConversionSystem) null : new GameObjectLookupConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubSceneNetworkedPrefabConversionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_gameObjectLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
