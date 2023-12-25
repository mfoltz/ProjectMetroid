// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Config
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices
{
  public static class Config : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LibraryName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LibraryCallingConvention;

    static Config()
    {
      Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (Config));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
      Config.NativeFieldInfoPtr_LibraryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (LibraryName));
      Config.NativeFieldInfoPtr_LibraryCallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (LibraryCallingConvention));
    }

    public Config(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LibraryName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_LibraryName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_LibraryName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Il2CppSystem.Runtime.InteropServices.CallingConvention LibraryCallingConvention
    {
      get
      {
        Il2CppSystem.Runtime.InteropServices.CallingConvention callingConvention;
        IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_LibraryCallingConvention, (void*) &callingConvention);
        return callingConvention;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_LibraryCallingConvention, (void*) &value);
      }
    }
  }
}
