// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicCollisionSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DynamicCollisionSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadiusOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadiusVariation;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRadius_Public_Single_Single_0;
    [FieldOffset(0)]
    public ModifiableFloat HardnessThreshold;
    [FieldOffset(8)]
    public ModifiableFloat PushStrengthMin;
    [FieldOffset(16)]
    public ModifiableFloat PushStrengthMax;
    [FieldOffset(24)]
    public float RadiusOverride;
    [FieldOffset(28)]
    public float RadiusVariation;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1006788, RefRangeEnd = 1006791, XrefRangeStart = 1006788, XrefRangeEnd = 1006788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetRadius(float defaultBaseRadius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &defaultBaseRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicCollisionSettings.NativeMethodInfoPtr_GetRadius_Public_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DynamicCollisionSettings()
    {
      Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DynamicCollisionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr);
      DynamicCollisionSettings.NativeFieldInfoPtr_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, nameof (HardnessThreshold));
      DynamicCollisionSettings.NativeFieldInfoPtr_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, nameof (PushStrengthMin));
      DynamicCollisionSettings.NativeFieldInfoPtr_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, nameof (PushStrengthMax));
      DynamicCollisionSettings.NativeFieldInfoPtr_RadiusOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, nameof (RadiusOverride));
      DynamicCollisionSettings.NativeFieldInfoPtr_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, nameof (RadiusVariation));
      DynamicCollisionSettings.NativeMethodInfoPtr_GetRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, 100678141);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicCollisionSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
