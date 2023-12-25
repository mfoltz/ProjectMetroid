// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Slashers_DashHit_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Slashers_DashHit_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellDamageImpact;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImpactSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_DashReturn;
    [FieldOffset(0)]
    public DealDamageParameters SpellDamageImpact;
    [FieldOffset(112)]
    public float Radius;
    [FieldOffset(116)]
    public SequenceGUID ImpactSequence;
    [FieldOffset(120)]
    public HitFilter HitFilter;
    [FieldOffset(121)]
    public bool DashReturn;

    static Script_Slashers_DashHit_DataServer()
    {
      Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Slashers_DashHit_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr);
      Script_Slashers_DashHit_DataServer.NativeFieldInfoPtr_SpellDamageImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, nameof (SpellDamageImpact));
      Script_Slashers_DashHit_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, nameof (Radius));
      Script_Slashers_DashHit_DataServer.NativeFieldInfoPtr_ImpactSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, nameof (ImpactSequence));
      Script_Slashers_DashHit_DataServer.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, nameof (HitFilter));
      Script_Slashers_DashHit_DataServer.NativeFieldInfoPtr_DashReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, nameof (DashReturn));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Slashers_DashHit_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
