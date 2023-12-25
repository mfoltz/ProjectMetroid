// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProfessorCoilManager
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextTickTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoredBuffModifications;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitBuffPrefabGuid;
    [FieldOffset(0)]
    public DealDamageParameters DamageParameters;
    [FieldOffset(112)]
    public double NextTickTime;
    [FieldOffset(120)]
    public BuffModificationTypes IgnoredBuffModifications;
    [FieldOffset(128)]
    public float TickRate;
    [FieldOffset(132)]
    public PrefabGUID HitBuffPrefabGuid;

    static ProfessorCoilManager()
    {
      Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr);
      ProfessorCoilManager.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, nameof (DamageParameters));
      ProfessorCoilManager.NativeFieldInfoPtr_NextTickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, nameof (NextTickTime));
      ProfessorCoilManager.NativeFieldInfoPtr_IgnoredBuffModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, nameof (IgnoredBuffModifications));
      ProfessorCoilManager.NativeFieldInfoPtr_TickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, nameof (TickRate));
      ProfessorCoilManager.NativeFieldInfoPtr_HitBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, nameof (HitBuffPrefabGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilManager>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
