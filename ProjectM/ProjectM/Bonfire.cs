// Decompiled with JetBrains decompiler
// Type: ProjectM.Bonfire
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Bonfire
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_Strength;
    private static readonly System.IntPtr NativeFieldInfoPtr_BurnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeToGetToFullStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeToGetToZeroStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;
    [FieldOffset(0)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(4)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(12)]
    public PrefabGUID InputItem;
    [FieldOffset(16)]
    public float Strength;
    [FieldOffset(20)]
    public float BurnTime;
    [FieldOffset(24)]
    public float TimeToGetToFullStrength;
    [FieldOffset(28)]
    public float TimeToGetToZeroStrength;
    [FieldOffset(32)]
    public float StartScale;
    [FieldOffset(36)]
    public float EndScale;
    [FieldOffset(40)]
    public bool IsActive;

    static Bonfire()
    {
      Il2CppClassPointerStore<Bonfire>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Bonfire));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bonfire>.NativeClassPtr);
      Bonfire.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Bonfire.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (ActiveSequenceState));
      Bonfire.NativeFieldInfoPtr_InputItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (InputItem));
      Bonfire.NativeFieldInfoPtr_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (Strength));
      Bonfire.NativeFieldInfoPtr_BurnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (BurnTime));
      Bonfire.NativeFieldInfoPtr_TimeToGetToFullStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (TimeToGetToFullStrength));
      Bonfire.NativeFieldInfoPtr_TimeToGetToZeroStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (TimeToGetToZeroStrength));
      Bonfire.NativeFieldInfoPtr_StartScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (StartScale));
      Bonfire.NativeFieldInfoPtr_EndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (EndScale));
      Bonfire.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, nameof (IsActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bonfire>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
