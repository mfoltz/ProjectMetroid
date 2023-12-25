// Decompiled with JetBrains decompiler
// Type: ProjectM.AdminUser
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AdminUser
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AuthMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    [FieldOffset(0)]
    public AdminAuthMethod AuthMethod;
    [FieldOffset(4)]
    public AdminLevel Level;

    static AdminUser()
    {
      Il2CppClassPointerStore<AdminUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AdminUser));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdminUser>.NativeClassPtr);
      AdminUser.NativeFieldInfoPtr_AuthMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminUser>.NativeClassPtr, nameof (AuthMethod));
      AdminUser.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminUser>.NativeClassPtr, nameof (Level));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdminUser>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
