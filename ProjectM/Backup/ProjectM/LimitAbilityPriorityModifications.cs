// Decompiled with JetBrains decompiler
// Type: ProjectM.LimitAbilityPriorityModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LimitAbilityPriorityModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitAbilityPriorityModificationId;
    [FieldOffset(0)]
    public ModificationId LimitAbilityPriorityModificationId;

    static LimitAbilityPriorityModifications()
    {
      Il2CppClassPointerStore<LimitAbilityPriorityModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LimitAbilityPriorityModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimitAbilityPriorityModifications>.NativeClassPtr);
      LimitAbilityPriorityModifications.NativeFieldInfoPtr_LimitAbilityPriorityModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitAbilityPriorityModifications>.NativeClassPtr, nameof (LimitAbilityPriorityModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LimitAbilityPriorityModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
