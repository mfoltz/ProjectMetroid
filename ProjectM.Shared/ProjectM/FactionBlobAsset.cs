// Decompiled with JetBrains decompiler
// Type: ProjectM.FactionBlobAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FactionBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Membership;
    private static readonly System.IntPtr NativeFieldInfoPtr_Friendly;
    private static readonly System.IntPtr NativeFieldInfoPtr_Neutral;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hostile;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroMultipliers;
    [FieldOffset(0)]
    public LocalizationKey Name;
    [FieldOffset(16)]
    public FactionEnum Membership;
    [FieldOffset(20)]
    public FactionEnum Friendly;
    [FieldOffset(24)]
    public FactionEnum Neutral;
    [FieldOffset(28)]
    public FactionEnum Hostile;
    [FieldOffset(32)]
    public int Index;
    [FieldOffset(36)]
    public BlobArray<AggroFactionMultiplierBufferElement> AggroMultipliers;

    static FactionBlobAsset()
    {
      Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FactionBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr);
      FactionBlobAsset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Name));
      FactionBlobAsset.NativeFieldInfoPtr_Membership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Membership));
      FactionBlobAsset.NativeFieldInfoPtr_Friendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Friendly));
      FactionBlobAsset.NativeFieldInfoPtr_Neutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Neutral));
      FactionBlobAsset.NativeFieldInfoPtr_Hostile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Hostile));
      FactionBlobAsset.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (Index));
      FactionBlobAsset.NativeFieldInfoPtr_AggroMultipliers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, nameof (AggroMultipliers));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FactionBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
