// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDMenuManager
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class HUDMenuManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleDebugMenu_Public_Static_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoToMenu_Public_Static_Void_byref_EntityCommandBuffer_HUDMenuType_Nullable_Unboxed_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseMenu_Public_Static_Void_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseMenu_Public_Static_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentMenu_Public_Static_HUDMenuType_World_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1276873, RefRangeEnd = 1276876, XrefRangeStart = 1276870, XrefRangeEnd = 1276873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleMenu(World clientWorld, HUDMenuType menu)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &menu;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276879, RefRangeEnd = 1276880, XrefRangeStart = 1276876, XrefRangeEnd = 1276879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleMenu<T>(
      World clientWorld,
      HUDMenuType menu,
      Nullable_Unboxed<T> initData = default (Nullable_Unboxed<T>))
      where T : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &menu;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.MethodInfoStoreGeneric_ToggleMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276880, XrefRangeEnd = 1276885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleDebugMenu(World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_ToggleDebugMenu_Public_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1276888, RefRangeEnd = 1276899, XrefRangeStart = 1276885, XrefRangeEnd = 1276888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GoToMenu(World clientWorld, HUDMenuType menu)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &menu;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276908, RefRangeEnd = 1276909, XrefRangeStart = 1276899, XrefRangeEnd = 1276908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GoToMenu<T>(
      World clientWorld,
      HUDMenuType menu,
      Nullable_Unboxed<T> initData = default (Nullable_Unboxed<T>))
      where T : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &menu;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.MethodInfoStoreGeneric_GoToMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276917, RefRangeEnd = 1276918, XrefRangeStart = 1276909, XrefRangeEnd = 1276917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GoToMenu<T>(
      ref EntityCommandBuffer ecb,
      HUDMenuType menu,
      Nullable_Unboxed<T> initData = default (Nullable_Unboxed<T>))
      where T : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref ecb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &menu;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.MethodInfoStoreGeneric_GoToMenu_Public_Static_Void_byref_EntityCommandBuffer_HUDMenuType_Nullable_Unboxed_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276918, XrefRangeEnd = 1276922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CloseMenu(ref EntityCommandBuffer ecb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref ecb;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_byref_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 1276927, RefRangeEnd = 1276955, XrefRangeStart = 1276922, XrefRangeEnd = 1276927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CloseMenu(World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1276958, RefRangeEnd = 1276966, XrefRangeStart = 1276955, XrefRangeEnd = 1276958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe HUDMenuType GetCurrentMenu(World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDMenuManager.NativeMethodInfoPtr_GetCurrentMenu_Public_Static_HUDMenuType_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HUDMenuType*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HUDMenuManager()
    {
      Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDMenuManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr);
      HUDMenuManager.NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668640);
      HUDMenuManager.NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668641);
      HUDMenuManager.NativeMethodInfoPtr_ToggleDebugMenu_Public_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668642);
      HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668643);
      HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668644);
      HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_byref_EntityCommandBuffer_HUDMenuType_Nullable_Unboxed_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668645);
      HUDMenuManager.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668646);
      HUDMenuManager.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668647);
      HUDMenuManager.NativeMethodInfoPtr_GetCurrentMenu_Public_Static_HUDMenuType_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, 100668648);
    }

    public HUDMenuManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EmptyInitData
    {
      static EmptyInitData()
      {
        Il2CppClassPointerStore<HUDMenuManager.EmptyInitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr, nameof (EmptyInitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMenuManager.EmptyInitData>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDMenuManager.EmptyInitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_ToggleMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HUDMenuManager.NativeMethodInfoPtr_ToggleMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0, Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GoToMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_World_HUDMenuType_Nullable_Unboxed_1_T_0, Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GoToMenu_Public_Static_Void_byref_EntityCommandBuffer_HUDMenuType_Nullable_Unboxed_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HUDMenuManager.NativeMethodInfoPtr_GoToMenu_Public_Static_Void_byref_EntityCommandBuffer_HUDMenuType_Nullable_Unboxed_1_T_0, Il2CppClassPointerStore<HUDMenuManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
