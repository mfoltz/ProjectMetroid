// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.AttachRecursiveComponentConversionSystem`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class AttachRecursiveComponentConversionSystem<TAuthoring, TComp> : 
    GameObjectConversionSystem
    where TAuthoring : RecursiveAuthoringComponent<TComp>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_TAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AttachRecursiveComponentConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767078, XrefRangeEnd = 767090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_0(Entity entity, TAuthoring attachComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TAuthoring& local1;
      if (!typeof (TAuthoring).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TAuthoring> local2 = (object) attachComponent;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TAuthoring&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TAuthoring&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref attachComponent;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_TAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AttachRecursiveComponentConversionSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", "AttachRecursiveComponentConversionSystem`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAuthoring>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComp>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr);
      AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr, 100667841);
      AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr, 100667842);
      AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr, 100667843);
      AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_TAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr, 100667844);
      AttachRecursiveComponentConversionSystem<TAuthoring, TComp>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachRecursiveComponentConversionSystem<TAuthoring, TComp>>.NativeClassPtr, 100667845);
    }

    public AttachRecursiveComponentConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
