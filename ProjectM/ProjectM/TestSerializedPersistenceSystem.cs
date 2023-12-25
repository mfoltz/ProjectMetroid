// Decompiled with JetBrains decompiler
// Type: ProjectM.TestSerializedPersistenceSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TestSerializedPersistenceSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__TestWorld;
    private static readonly IntPtr NativeFieldInfoPtr__GameBootstarp;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_35;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_TestPersistenceV2Save_36;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061643, XrefRangeEnd = 1061646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061646, XrefRangeEnd = 1061648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestSerializedPersistenceSystem.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061648, XrefRangeEnd = 1061685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestSerializedPersistenceSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestSerializedPersistenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061685, XrefRangeEnd = 1061699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TestSerializedPersistenceSystem()
    {
      Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TestSerializedPersistenceSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr);
      TestSerializedPersistenceSystem.NativeFieldInfoPtr__TestWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, nameof (_TestWorld));
      TestSerializedPersistenceSystem.NativeFieldInfoPtr__GameBootstarp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, nameof (_GameBootstarp));
      TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_PersistenceDebuggingSingleton_35));
      TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_TestPersistenceV2Save_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_TestPersistenceV2Save_36));
      TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683289);
      TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683290);
      TestSerializedPersistenceSystem.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683291);
      TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683292);
      TestSerializedPersistenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683293);
      TestSerializedPersistenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSerializedPersistenceSystem>.NativeClassPtr, 100683294);
    }

    public TestSerializedPersistenceSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe World _TestWorld
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__TestWorld));
        return pointer == IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__TestWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameBootstrap _GameBootstarp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__GameBootstarp));
        return pointer == IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__GameBootstarp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_PersistenceDebuggingSingleton_35
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_35));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_35)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_TestPersistenceV2Save_36
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_TestPersistenceV2Save_36));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestSerializedPersistenceSystem.NativeFieldInfoPtr__SingletonEntityQuery_TestPersistenceV2Save_36)) = value;
      }
    }
  }
}
