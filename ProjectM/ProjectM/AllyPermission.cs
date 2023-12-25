// Decompiled with JetBrains decompiler
// Type: ProjectM.AllyPermission
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AllyPermission
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_Permissions;
    [FieldOffset(0)]
    public NetworkedEntity User;
    [FieldOffset(12)]
    public AllyPermissionFlag Permissions;

    static AllyPermission()
    {
      Il2CppClassPointerStore<AllyPermission>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AllyPermission));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllyPermission>.NativeClassPtr);
      AllyPermission.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllyPermission>.NativeClassPtr, nameof (User));
      AllyPermission.NativeFieldInfoPtr_Permissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllyPermission>.NativeClassPtr, nameof (Permissions));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllyPermission>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
