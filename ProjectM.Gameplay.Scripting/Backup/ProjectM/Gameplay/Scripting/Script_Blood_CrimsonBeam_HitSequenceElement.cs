// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_HitSequenceElement
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Blood_CrimsonBeam_HitSequenceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ally;
    [FieldOffset(0)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(4)]
    public bool Ally;

    static Script_Blood_CrimsonBeam_HitSequenceElement()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitSequenceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam_HitSequenceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitSequenceElement>.NativeClassPtr);
      Script_Blood_CrimsonBeam_HitSequenceElement.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitSequenceElement>.NativeClassPtr, nameof (SequenceGuid));
      Script_Blood_CrimsonBeam_HitSequenceElement.NativeFieldInfoPtr_Ally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitSequenceElement>.NativeClassPtr, nameof (Ally));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitSequenceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
