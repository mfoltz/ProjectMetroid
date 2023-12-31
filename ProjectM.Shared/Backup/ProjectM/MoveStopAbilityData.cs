// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveStopAbilityData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MoveStopAbilityData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceAngle;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public float UnitAngle;
    [FieldOffset(8)]
    public float ResourceAngle;

    static MoveStopAbilityData()
    {
      Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MoveStopAbilityData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr);
      MoveStopAbilityData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr, nameof (Radius));
      MoveStopAbilityData.NativeFieldInfoPtr_UnitAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr, nameof (UnitAngle));
      MoveStopAbilityData.NativeFieldInfoPtr_ResourceAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr, nameof (ResourceAngle));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveStopAbilityData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
