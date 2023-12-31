// Decompiled with JetBrains decompiler
// Type: ProjectM.StunApplication
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class StunApplication : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistentDataPath;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckInit_Private_Static_Void_0;

    public static unsafe string persistentDataPath
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 735804, RefRangeEnd = 735806, XrefRangeStart = 735777, XrefRangeEnd = 735804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunApplication.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735806, XrefRangeEnd = 735828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckInit()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunApplication.NativeMethodInfoPtr_CheckInit_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunApplication()
    {
      Il2CppClassPointerStore<StunApplication>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StunApplication));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunApplication>.NativeClassPtr);
      StunApplication.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunApplication>.NativeClassPtr, nameof (_Initialized));
      StunApplication.NativeFieldInfoPtr__PersistentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunApplication>.NativeClassPtr, nameof (_PersistentDataPath));
      StunApplication.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunApplication>.NativeClassPtr, 100664964);
      StunApplication.NativeMethodInfoPtr_CheckInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunApplication>.NativeClassPtr, 100664965);
    }

    public StunApplication(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _Initialized
    {
      get
      {
        bool initialized;
        IL2CPP.il2cpp_field_static_get_value(StunApplication.NativeFieldInfoPtr__Initialized, (void*) &initialized);
        return initialized;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunApplication.NativeFieldInfoPtr__Initialized, (void*) &value);
      }
    }

    public static unsafe string _PersistentDataPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunApplication.NativeFieldInfoPtr__PersistentDataPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunApplication.NativeFieldInfoPtr__PersistentDataPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
