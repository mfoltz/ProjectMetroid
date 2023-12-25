// Decompiled with JetBrains decompiler
// Type: ProjectM.RepairRequirementBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RepairRequirementBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredAmount;
    [FieldOffset(0)]
    public PrefabGUID ItemGuid;
    [FieldOffset(4)]
    public int RequiredAmount;

    static RepairRequirementBuffer()
    {
      Il2CppClassPointerStore<RepairRequirementBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RepairRequirementBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairRequirementBuffer>.NativeClassPtr);
      RepairRequirementBuffer.NativeFieldInfoPtr_ItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairRequirementBuffer>.NativeClassPtr, nameof (ItemGuid));
      RepairRequirementBuffer.NativeFieldInfoPtr_RequiredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairRequirementBuffer>.NativeClassPtr, nameof (RequiredAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairRequirementBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
