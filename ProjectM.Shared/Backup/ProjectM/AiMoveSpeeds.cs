// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveSpeeds
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiMoveSpeeds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Walk;
    private static readonly System.IntPtr NativeFieldInfoPtr_Run;
    private static readonly System.IntPtr NativeFieldInfoPtr_Circle;
    private static readonly System.IntPtr NativeFieldInfoPtr_Return;
    private static readonly System.IntPtr NativeFieldInfoPtr_Variation;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Private_Single_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_AiMoveSpeed_Boolean_0;
    [FieldOffset(0)]
    public float Walk;
    [FieldOffset(4)]
    public float Run;
    [FieldOffset(8)]
    public float Circle;
    [FieldOffset(12)]
    public float Return;
    [FieldOffset(16)]
    public float Variation;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 723027, RefRangeEnd = 723029, XrefRangeStart = 723025, XrefRangeEnd = 723027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Get(float value, bool withVariation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &withVariation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSpeeds.NativeMethodInfoPtr_Get_Private_Single_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 723035, RefRangeEnd = 723038, XrefRangeStart = 723029, XrefRangeEnd = 723035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Get(AiMoveSpeed speed, bool withVariation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &withVariation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSpeeds.NativeMethodInfoPtr_Get_Public_Single_AiMoveSpeed_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AiMoveSpeeds()
    {
      Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiMoveSpeeds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr);
      AiMoveSpeeds.NativeFieldInfoPtr_Walk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, nameof (Walk));
      AiMoveSpeeds.NativeFieldInfoPtr_Run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, nameof (Run));
      AiMoveSpeeds.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, nameof (Circle));
      AiMoveSpeeds.NativeFieldInfoPtr_Return = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, nameof (Return));
      AiMoveSpeeds.NativeFieldInfoPtr_Variation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, nameof (Variation));
      AiMoveSpeeds.NativeMethodInfoPtr_Get_Private_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, 100663884);
      AiMoveSpeeds.NativeMethodInfoPtr_Get_Public_Single_AiMoveSpeed_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, 100663885);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSpeeds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
