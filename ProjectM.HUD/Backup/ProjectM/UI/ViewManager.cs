// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ViewManager
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

#nullable disable
namespace ProjectM.UI
{
  public static class ViewManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_Nullable_Unboxed_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentView_Public_Static_ViewLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_ViewLocation_0;

    [CallerCount(72)]
    [CachedScanResults(RefRangeStart = 1277146, RefRangeEnd = 1277218, XrefRangeStart = 1277143, XrefRangeEnd = 1277146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GoToView(ViewLocation view)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &view;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1277240, RefRangeEnd = 1277241, XrefRangeStart = 1277218, XrefRangeEnd = 1277240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GoToView<T>(ViewLocation view, Nullable_Unboxed<T> initData = default (Nullable_Unboxed<T>)) where T : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &view;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ViewManager.MethodInfoStoreGeneric_GoToView_Public_Static_Void_ViewLocation_Nullable_Unboxed_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1277247, RefRangeEnd = 1277250, XrefRangeStart = 1277241, XrefRangeEnd = 1277247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ViewLocation GetCurrentView()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_GetCurrentView_Public_Static_ViewLocation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ViewLocation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1277256, RefRangeEnd = 1277257, XrefRangeStart = 1277250, XrefRangeEnd = 1277256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInMenu()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277257, XrefRangeEnd = 1277263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInMenu(ViewLocation menuLocation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &menuLocation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_ViewLocation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ViewManager()
    {
      Il2CppClassPointerStore<ViewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ViewManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewManager>.NativeClassPtr);
      ViewManager.NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100668669);
      ViewManager.NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_Nullable_Unboxed_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100668670);
      ViewManager.NativeMethodInfoPtr_GetCurrentView_Public_Static_ViewLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100668671);
      ViewManager.NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100668672);
      ViewManager.NativeMethodInfoPtr_IsInMenu_Public_Static_Boolean_ViewLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100668673);
    }

    public ViewManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_GoToView_Public_Static_Void_ViewLocation_Nullable_Unboxed_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ViewManager.NativeMethodInfoPtr_GoToView_Public_Static_Void_ViewLocation_Nullable_Unboxed_1_T_0, Il2CppClassPointerStore<ViewManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
