// Decompiled with JetBrains decompiler
// Type: ProjectM.BootstrapUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class BootstrapUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_STARTUP_FILE;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSubsceneLoadInfo_Internal_Static_Void_SceneSystem_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 977538, RefRangeEnd = 977540, XrefRangeStart = 977509, XrefRangeEnd = 977538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetSubsceneLoadInfo(
      SceneSystem sceneSystem,
      out int numOfLoaded,
      out int numOfRequested)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref numOfLoaded;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref numOfRequested;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BootstrapUtility.NativeMethodInfoPtr_GetSubsceneLoadInfo_Internal_Static_Void_SceneSystem_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BootstrapUtility()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BootstrapUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BootstrapUtility()
    {
      Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BootstrapUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr);
      BootstrapUtility.NativeFieldInfoPtr_SERVER_STARTUP_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr, nameof (SERVER_STARTUP_FILE));
      BootstrapUtility.NativeMethodInfoPtr_GetSubsceneLoadInfo_Internal_Static_Void_SceneSystem_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr, 100675553);
      BootstrapUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootstrapUtility>.NativeClassPtr, 100675554);
    }

    public BootstrapUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string SERVER_STARTUP_FILE
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(BootstrapUtility.NativeFieldInfoPtr_SERVER_STARTUP_FILE, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BootstrapUtility.NativeFieldInfoPtr_SERVER_STARTUP_FILE, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
