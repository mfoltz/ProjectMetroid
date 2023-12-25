// Decompiled with JetBrains decompiler
// Type: ProjectM.FollowBuffOwnerModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FollowBuffOwnerModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowedModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowModeModId;
    [FieldOffset(0)]
    public ModificationId FollowedModId;
    [FieldOffset(4)]
    public ModificationId FollowModeModId;

    static FollowBuffOwnerModifications()
    {
      Il2CppClassPointerStore<FollowBuffOwnerModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FollowBuffOwnerModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FollowBuffOwnerModifications>.NativeClassPtr);
      FollowBuffOwnerModifications.NativeFieldInfoPtr_FollowedModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FollowBuffOwnerModifications>.NativeClassPtr, nameof (FollowedModId));
      FollowBuffOwnerModifications.NativeFieldInfoPtr_FollowModeModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FollowBuffOwnerModifications>.NativeClassPtr, nameof (FollowModeModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FollowBuffOwnerModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
