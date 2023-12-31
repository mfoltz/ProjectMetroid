// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WorldUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FindWorld_Public_Static_World_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultWorld_Public_Static_get_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindServerWorld_Public_Static_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindClientWorld_Public_Static_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindEditorWorld_Public_Static_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsServerWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsClientWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSubSceneStreamingWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUnitTestingWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEditorWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsConversionWorld_Public_Static_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanUpPhysicsGarbage_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedTimestep_Public_Static_Void_ComponentSystemGroup_Boolean_Single_0;

    [CallerCount(79)]
    [CachedScanResults(RefRangeStart = 764523, RefRangeEnd = 764602, XrefRangeStart = 764494, XrefRangeEnd = 764523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World FindWorld(string name, bool includeInactive = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeInactive;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_FindWorld_Public_Static_World_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    public static unsafe World DefaultWorld
    {
      [CallerCount(48), CachedScanResults(RefRangeStart = 764605, RefRangeEnd = 764653, XrefRangeStart = 764602, XrefRangeEnd = 764605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_get_DefaultWorld_Public_Static_get_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764656, RefRangeEnd = 764657, XrefRangeStart = 764653, XrefRangeEnd = 764656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World FindServerWorld()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_FindServerWorld_Public_Static_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764660, RefRangeEnd = 764661, XrefRangeStart = 764657, XrefRangeEnd = 764660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World FindClientWorld()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_FindClientWorld_Public_Static_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764664, RefRangeEnd = 764665, XrefRangeStart = 764661, XrefRangeEnd = 764664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World FindEditorWorld()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_FindEditorWorld_Public_Static_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(40)]
    [CachedScanResults(RefRangeStart = 764669, RefRangeEnd = 764709, XrefRangeStart = 764665, XrefRangeEnd = 764669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsServerWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsServerWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 764713, RefRangeEnd = 764724, XrefRangeStart = 764709, XrefRangeEnd = 764713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsClientWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsClientWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764728, RefRangeEnd = 764729, XrefRangeStart = 764724, XrefRangeEnd = 764728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSubSceneStreamingWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsSubSceneStreamingWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764733, RefRangeEnd = 764734, XrefRangeStart = 764729, XrefRangeEnd = 764733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsUnitTestingWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsUnitTestingWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 764738, RefRangeEnd = 764749, XrefRangeStart = 764734, XrefRangeEnd = 764738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsEditorWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsEditorWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 764753, RefRangeEnd = 764758, XrefRangeStart = 764749, XrefRangeEnd = 764753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsConversionWorld(this World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_IsConversionWorld_Public_Static_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764770, RefRangeEnd = 764771, XrefRangeStart = 764758, XrefRangeEnd = 764770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanUpPhysicsGarbage()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_CleanUpPhysicsGarbage_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764771, XrefRangeEnd = 764773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetFixedTimestep(
      this ComponentSystemGroup system,
      bool enabled,
      float deltaTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldUtility.NativeMethodInfoPtr_SetFixedTimestep_Public_Static_Void_ComponentSystemGroup_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldUtility()
    {
      Il2CppClassPointerStore<WorldUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr);
      WorldUtility.NativeMethodInfoPtr_FindWorld_Public_Static_World_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667530);
      WorldUtility.NativeMethodInfoPtr_get_DefaultWorld_Public_Static_get_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667531);
      WorldUtility.NativeMethodInfoPtr_FindServerWorld_Public_Static_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667532);
      WorldUtility.NativeMethodInfoPtr_FindClientWorld_Public_Static_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667533);
      WorldUtility.NativeMethodInfoPtr_FindEditorWorld_Public_Static_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667534);
      WorldUtility.NativeMethodInfoPtr_IsServerWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667535);
      WorldUtility.NativeMethodInfoPtr_IsClientWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667536);
      WorldUtility.NativeMethodInfoPtr_IsSubSceneStreamingWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667537);
      WorldUtility.NativeMethodInfoPtr_IsUnitTestingWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667538);
      WorldUtility.NativeMethodInfoPtr_IsEditorWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667539);
      WorldUtility.NativeMethodInfoPtr_IsConversionWorld_Public_Static_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667540);
      WorldUtility.NativeMethodInfoPtr_CleanUpPhysicsGarbage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667541);
      WorldUtility.NativeMethodInfoPtr_SetFixedTimestep_Public_Static_Void_ComponentSystemGroup_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldUtility>.NativeClassPtr, 100667542);
    }

    public WorldUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
