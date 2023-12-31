// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTypeFlag;
    [FieldOffset(0)]
    public PrefabGUID AbilityId;
    [FieldOffset(4)]
    public NetworkedEntity GroupEntity;
    [FieldOffset(16)]
    public AbilityTypeFlag AbilityTypeFlag;

    static AbilityState()
    {
      Il2CppClassPointerStore<AbilityState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityState>.NativeClassPtr);
      AbilityState.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityState>.NativeClassPtr, nameof (AbilityId));
      AbilityState.NativeFieldInfoPtr_GroupEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityState>.NativeClassPtr, nameof (GroupEntity));
      AbilityState.NativeFieldInfoPtr_AbilityTypeFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityState>.NativeClassPtr, nameof (AbilityTypeFlag));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
