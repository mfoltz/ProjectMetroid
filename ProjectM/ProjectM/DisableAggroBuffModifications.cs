// Decompiled with JetBrains decompiler
// Type: ProjectM.DisableAggroBuffModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DisableAggroBuffModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OthersDontAttackTargetModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDontAttackOthersModId;
    [FieldOffset(0)]
    public ModificationId OthersDontAttackTargetModId;
    [FieldOffset(4)]
    public ModificationId TargetDontAttackOthersModId;

    static DisableAggroBuffModifications()
    {
      Il2CppClassPointerStore<DisableAggroBuffModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DisableAggroBuffModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableAggroBuffModifications>.NativeClassPtr);
      DisableAggroBuffModifications.NativeFieldInfoPtr_OthersDontAttackTargetModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableAggroBuffModifications>.NativeClassPtr, nameof (OthersDontAttackTargetModId));
      DisableAggroBuffModifications.NativeFieldInfoPtr_TargetDontAttackOthersModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableAggroBuffModifications>.NativeClassPtr, nameof (TargetDontAttackOthersModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableAggroBuffModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
