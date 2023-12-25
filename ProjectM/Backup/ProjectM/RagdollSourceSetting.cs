// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollSourceSetting
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RagdollSourceSetting
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualDirectionWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritDirectionWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_AwayFromSourceWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_TowardsSourceWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AwayFromSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_TowardsSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseManualDirection;
    [FieldOffset(0)]
    public float3 ManualDirection;
    [FieldOffset(12)]
    public float Force;
    [FieldOffset(16)]
    public float ManualDirectionWeight;
    [FieldOffset(20)]
    public float InheritDirectionWeight;
    [FieldOffset(24)]
    public float AwayFromSourceWeight;
    [FieldOffset(28)]
    public float TowardsSourceWeight;
    [FieldOffset(32)]
    public bool InheritDirection;
    [FieldOffset(33)]
    public bool AwayFromSource;
    [FieldOffset(34)]
    public bool TowardsSource;
    [FieldOffset(35)]
    public bool UseManualDirection;

    static RagdollSourceSetting()
    {
      Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollSourceSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr);
      RagdollSourceSetting.NativeFieldInfoPtr_ManualDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (ManualDirection));
      RagdollSourceSetting.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (Force));
      RagdollSourceSetting.NativeFieldInfoPtr_ManualDirectionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (ManualDirectionWeight));
      RagdollSourceSetting.NativeFieldInfoPtr_InheritDirectionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (InheritDirectionWeight));
      RagdollSourceSetting.NativeFieldInfoPtr_AwayFromSourceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (AwayFromSourceWeight));
      RagdollSourceSetting.NativeFieldInfoPtr_TowardsSourceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (TowardsSourceWeight));
      RagdollSourceSetting.NativeFieldInfoPtr_InheritDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (InheritDirection));
      RagdollSourceSetting.NativeFieldInfoPtr_AwayFromSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (AwayFromSource));
      RagdollSourceSetting.NativeFieldInfoPtr_TowardsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (TowardsSource));
      RagdollSourceSetting.NativeFieldInfoPtr_UseManualDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, nameof (UseManualDirection));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollSourceSetting>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
