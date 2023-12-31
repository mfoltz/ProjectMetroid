// Decompiled with JetBrains decompiler
// Type: ProjectM.HealthConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HealthConstants
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LowHealthFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableDamageSCT;
    [FieldOffset(0)]
    public float LowHealthFactor;
    [FieldOffset(4)]
    public bool DestroyOnDeath;
    [FieldOffset(8)]
    public float DestroyAfterDuration;
    [FieldOffset(12)]
    public bool DisableDamageSCT;

    static HealthConstants()
    {
      Il2CppClassPointerStore<HealthConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HealthConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr);
      HealthConstants.NativeFieldInfoPtr_LowHealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr, nameof (LowHealthFactor));
      HealthConstants.NativeFieldInfoPtr_DestroyOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr, nameof (DestroyOnDeath));
      HealthConstants.NativeFieldInfoPtr_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr, nameof (DestroyAfterDuration));
      HealthConstants.NativeFieldInfoPtr_DisableDamageSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr, nameof (DisableDamageSCT));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HealthConstants>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
