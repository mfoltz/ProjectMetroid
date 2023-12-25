// Decompiled with JetBrains decompiler
// Type: ProjectM.HUD.ConditionalInfoElement
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.HUD
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionalInfoElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Placement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    [FieldOffset(0)]
    public InfoTextPlacement Placement;
    [FieldOffset(1)]
    public InfoTextType Type;
    [FieldOffset(4)]
    public LocalizationKey Text;
    [FieldOffset(20)]
    public float3 LocalOffset;
    [FieldOffset(32)]
    public BlobAssetReference<ConditionBlob> Conditional;

    static ConditionalInfoElement()
    {
      Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.HUD", nameof (ConditionalInfoElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr);
      ConditionalInfoElement.NativeFieldInfoPtr_Placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, nameof (Placement));
      ConditionalInfoElement.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, nameof (Type));
      ConditionalInfoElement.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, nameof (Text));
      ConditionalInfoElement.NativeFieldInfoPtr_LocalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, nameof (LocalOffset));
      ConditionalInfoElement.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, nameof (Conditional));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionalInfoElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
