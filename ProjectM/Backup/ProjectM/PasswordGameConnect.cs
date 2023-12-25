// Decompiled with JetBrains decompiler
// Type: ProjectM.PasswordGameConnect
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PasswordGameConnect
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectData;
    [FieldOffset(0)]
    public GameConnect ConnectData;

    static PasswordGameConnect()
    {
      Il2CppClassPointerStore<PasswordGameConnect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PasswordGameConnect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasswordGameConnect>.NativeClassPtr);
      PasswordGameConnect.NativeFieldInfoPtr_ConnectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordGameConnect>.NativeClassPtr, nameof (ConnectData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PasswordGameConnect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
